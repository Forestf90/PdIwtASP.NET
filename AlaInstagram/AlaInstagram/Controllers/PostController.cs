using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AlaInstagram.DAL;
using AlaInstagram.Models;
using AlaInstagram.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlaInstagram.Controllers
{
    public class PostController : Controller
    {
        //public static List<Post> PublishedPosts { get; set; } = new List<Post>();
        //private IInstagramData _instagramDate;
        private IHostingEnvironment _enviroment;

        private InstagramContext _context;
        public PostController(IHostingEnvironment enviroment)
        {
            _enviroment = enviroment;
            //// _instagramDate = new MemoryInstagramData();
            // _instagramDate = new EntityInstagramData();
            _context = new InstagramContext();
        }
        // GET: Post
        public ActionResult Index()
        {
            var postTag = _context.Tags.SelectMany(g => g.PostTags).Select(qq => qq.Tag);
            var tagi = postTag.Select(w => w.Name).ToList();
            var displayPostViewModels = _context.Posts.Select(n => new DisplayViewModel
            {
                Title = n.Title,
                PhotosPath = n.PhotosPath,
                Tags = n.PostTags.Select(c=> c.Tag.Name).ToList()
                //Tags = _instagramDate.GetTags().Where(l =>l.PostTags.Any(rr => rr.PostId==n.Id)).Select(c => c.Name).ToList()
                //Tags = tagi

            });


            return View(displayPostViewModels);
        }


        // GET: Post/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Post/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PostViewModel postViewModel)
        {
            try
            {
                
                if (ModelState.IsValid)
                {
                    var folderName = "upload/";
                    foreach (IFormFile file in postViewModel.Photos)
                    {
                        var savePath = Path.Combine(_enviroment.WebRootPath, folderName,
                                        file.FileName);

                        using (var photoFile = new FileStream(savePath, FileMode.Create))
                        {
                            file.CopyTo(photoFile);
                        }
                    }
                    //folderName+"/"+postViewModel.Photos.FileName
                    var newTags = postViewModel.CommaSeparatedTags.Split(",");
                    List<PostTag> listTags = new List<PostTag>();
                    foreach(var s in newTags)
                    {
                        if (_context.Tags.Where(x => x.Name == s).Any())
                        {
                            listTags.Add(new PostTag { Tag = _context.Tags.Where(x => x.Name == s).First()});
                        }
                        else
                        {
                            listTags.Add(new PostTag { Tag = new Tag { Name = s } });
                        }
                    }
                    // Select(x =>new PostTag{x.Tag = _context.Tags.Where} )
                    _context.AddPost(new Post
                    {
                        Id = Guid.NewGuid(),
                        Title = postViewModel.Title,
                        PhotosPath = postViewModel.Photos.Select(p => folderName + "/" + p.FileName),
                        PostTags = listTags
                        //postViewModel.CommaSeparatedTags
                        //.Split(",")
                        //.Select(x => new PostTag { Tag =new Tag { Name = x } })
                        //.ToList()

                        //PostTags.Tags = postViewModel.CommaSeparatedTags
                        //.Split(",")
                        //.Select(x => new Tag { Name =x})
                        //.ToList()
                    });
                    return RedirectToAction(nameof(Index));
                }
                return View(postViewModel);
            }
            catch
            {
                return View();
            }
        }

       
    }
}
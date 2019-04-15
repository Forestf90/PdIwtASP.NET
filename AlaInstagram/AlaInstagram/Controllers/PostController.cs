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
        private IInstagramData _instagramDate;
        private IHostingEnvironment _enviroment;

        public PostController(IHostingEnvironment enviroment)
        {
            _enviroment = enviroment;
           // _instagramDate = new MemoryInstagramData();
            _instagramDate = new EntityInstagramData();
        }
        // GET: Post
        public ActionResult Index()
        {
            var displayPostViewModels = _instagramDate.GetPosts().Select(n => new DisplayViewModel
            {
                Title = n.Title,
                PhotosPath = n.PhotosPath,
                //Tags = n.PostTags.Select(x => x.Tag.Name).ToList()
                //Tags = n.PostTags.Where(x => x.TagId == x.Tag.Id).Select(y => y.Tag.Name).ToList()
                //k=> k.PostId==n.Id
                //Tags = _instagramDate.GetTags().
                //        Where(m => m.PostTags.
                //        All(k => k.PostId == n.Id && m.Id == k.TagId)).
                //        Select(x => x.Name).
                //        ToList()
                //Tags = _instagramDate.GetTags().
                //        Where(o => o.PostTags.
                //        All(p => p.PostId == n.Id)).
                //        Where(m => m.PostTags.
                //        All(k => k.TagId == m.Id)).
                //        Select(x => x.Name).
                //        ToList()

                //tagPosts.Where(post => post.PostTags.Any(tag => tag.Tag.Name == selectedTag))
                //Tags = n.PostTags.Join(_instagramDate.GetTags()
                //  , x => x.TagId
                //  , s => s.Id
                //  , (s, x) => (s,x).ToTuple().Item1.Tag.Name).ToList()
                   //Select().ToList())

                // Tags = n.PostTags.Where(h=> h.PostId==n.Id).Select(y => y.Tag.Name).ToList()
                Tags = n.PostTag.Select(c=> c.Tag.Name).ToList()

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
                    _instagramDate.SavePost(new Post
                    {
                        Id = Guid.NewGuid(),
                        Title = postViewModel.Title,
                        PhotosPath = postViewModel.Photos.Select(p => folderName + "/" + p.FileName),
                        PostTag = postViewModel.CommaSeparatedTags
                        .Split(",")
                        .Select(x => new PostTag { Tag =new Tag { Name = x } })
                        .ToList()

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
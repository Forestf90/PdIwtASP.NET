using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AlaInstagram.Models;
using AlaInstagram.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlaInstagram.Controllers
{
    public class PostController : Controller
    {
        public static List<Post> PublishedPosts { get; set; } = new List<Post>();

        private IHostingEnvironment _enviroment;

        public PostController(IHostingEnvironment enviroment)
        {
            _enviroment = enviroment;
        }
        // GET: Post
        public ActionResult Index()
        {
            var displayPostViewModels = PublishedPosts.Select(n => new DisplayViewModel
            {
                Title = n.Title,
                PhotosPath = n.PhotosPath,
                Tags = n.Tags.Select(x => x.Name).ToList()
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
                    PublishedPosts.Add(new Post
                    {
                        Id = Guid.NewGuid(),
                        Title = postViewModel.Title,
                        PhotosPath=  postViewModel.Photos.Select(p => folderName + "/" + p.FileName),
                        Tags = postViewModel.CommaSeparatedTags
                        .Split(",")
                        .Select(x => new Tag { Name =x})
                        .ToList()
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
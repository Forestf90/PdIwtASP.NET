using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlaInstagram.Models;
using Microsoft.EntityFrameworkCore;

namespace AlaInstagram.DAL
{
    public class EntityInstagramData : IInstagramData
    {
        private InstagramContext _context;

        public EntityInstagramData()
        {
            _context = new InstagramContext();
            _context.Database.EnsureCreated();
        }

        public IEnumerable<Post> GetPosts()
        {
            return _context.Posts;
        }

        public IEnumerable<Tag> GetTags()
        {

            return _context.Tags;
        }

        public void SavePost(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
        }
    }
}

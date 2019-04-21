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
        public InstagramContext context;

        public EntityInstagramData()
        {
            context = new InstagramContext();
            context.Database.EnsureCreated();
        }

        public IEnumerable<Post> GetPosts()
        {
            return context.Posts;
        }

        public IEnumerable<Tag> GetTags()
        {

            return context.Tags;
        }

        public void SavePost(Post post)
        {
            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}

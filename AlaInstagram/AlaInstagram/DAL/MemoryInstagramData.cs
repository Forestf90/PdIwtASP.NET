using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlaInstagram.Models;

namespace AlaInstagram.DAL
{
    public class MemoryInstagramData : IInstagramData
    {
        private static List<Post> PublishedPosts { get; set; } = new List<Post>();
        public IEnumerable<Post> GetPosts()
        {
         
            return PublishedPosts;
        }

        public IEnumerable<Tag> GetTags()
        {
            //List<PostTag> x = PublishedPosts.SelectMany(y => y.PostTags).ToList();
            return PublishedPosts.SelectMany(x => x.PostTags.Select(y => y.Tag)).ToList();
        }

        public void SavePost(Post post)
        {
            PublishedPosts.Add(post);
        }
    }
}

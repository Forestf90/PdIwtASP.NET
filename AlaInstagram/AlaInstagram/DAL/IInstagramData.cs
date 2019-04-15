using AlaInstagram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlaInstagram.DAL
{
    interface IInstagramData
    {
        IEnumerable<Post> GetPosts();
        IEnumerable<Tag> GetTags();
        void SavePost(Post post);
    }
}

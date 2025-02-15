﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlaInstagram.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<string> PhotosPath { get; set; }
        public virtual ICollection<PostTag> PostTags { get; set; }

        public Post()
        {
            PostTags = new HashSet<PostTag>();
        }
    }
}

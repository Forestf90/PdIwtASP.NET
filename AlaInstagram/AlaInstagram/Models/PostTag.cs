﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlaInstagram.Models
{
    public class PostTag
    {
        public int Id { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
        public Guid PostId { get; set; }
        public Post Post { get; set; }
    }
}

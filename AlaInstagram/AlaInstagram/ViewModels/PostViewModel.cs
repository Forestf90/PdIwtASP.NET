﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlaInstagram.ViewModels
{
    public class PostViewModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string CommaSeparatedTags { get; set; }
        [Required]
        public IFormFileCollection Photos { get; set; }
    }
}

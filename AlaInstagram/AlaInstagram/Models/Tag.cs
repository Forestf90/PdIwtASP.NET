using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlaInstagram.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<PostTag> PostTag { get; set; }
        public Tag()
        {
            PostTag = new HashSet<PostTag>();
        }
    }

}

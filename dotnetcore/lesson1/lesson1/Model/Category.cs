using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace lesson1.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }

        public string Icon { get; set; }

        public List<Product> products { get; set; }
    }
}

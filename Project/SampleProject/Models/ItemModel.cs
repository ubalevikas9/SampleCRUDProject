using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProject.Models
{
    public class ItemModel
    {
        [Key]
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }

    }
}

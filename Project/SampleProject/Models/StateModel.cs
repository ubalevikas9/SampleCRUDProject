using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProject.Models
{
    public class StateModel
    {
        [Key]
        public int STATE_Id { get; set; }
        public string STATE_CODE { get; set; }
        public string STATE_NAME { get; set; }

    }
}

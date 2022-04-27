using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarsAdvisors.Models
{
    public class Maker
    {
        public int ID { get; set; }
        [Unique]
        [Required]
        [Display(Name = "Make Name")]
        public string MakerName { get; set; }
        [Display(Name = "Make Image")]
        [Required]

        public string MakerImage { get; set; }
        public virtual List<Model> Models { get; set; }

    }
}

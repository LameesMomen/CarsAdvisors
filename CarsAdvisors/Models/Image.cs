using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarsAdvisors.Models
{
    public class Image
    {
        public int ID { get; set; }
        [Display(Name = "Image")]
        [RegularExpression(@"\w*\.(jpg|png)")]

        public string ImageName { get; set; }
        [ForeignKey("Model")]
        [Display(Name = "Model")]
        public int Model_ID { get; set; }
        public virtual Model Model { get; set; }
    }
}

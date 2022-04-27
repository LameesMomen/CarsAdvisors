using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarsAdvisors.Models
{
    public class Compare
    {
        [Key]
        public int CompareID { get; set; }
        [ForeignKey("Model")]
        [Display(Name = "Model")]

        public int Model_ID { get; set; }
        public string User_ID { get; set; }
        public virtual Model Model { get; set; }
    }
}

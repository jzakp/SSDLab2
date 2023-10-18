// I, Jacob Streun, student number 000046995, certify that this material is my
// original work. No other person's work has been used without due
// acknowledgement and I have not made my work available to anyone else.
using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class Employer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required, Phone]
        public string PhoneNumber { get; set; }
        [Required, DataType(DataType.Url)]
        public string Website { get; set; }
        [DataType(DataType.Date)]
        public String? IncorpporatedDate { get; set; }
    }
}

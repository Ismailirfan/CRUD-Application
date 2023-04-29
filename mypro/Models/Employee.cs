using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace mypro.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please must be provided you name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please must be provided you Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}

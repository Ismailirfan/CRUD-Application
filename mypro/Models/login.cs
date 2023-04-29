using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace mypro.Models
{
    public class login
    {
        public int Id { get; set; }
        [MinLength(3,ErrorMessage ="Min 3 Char Required"),MaxLength(50)]
        [Display(Name="User Name")]
        public string Username { get; set; }
        [MinLength(3,ErrorMessage = "Min 3 Char Required"),MaxLength(50)]
    }
}

using System.ComponentModel.DataAnnotations;

namespace plz.Models
{
    public class Student
    {
        private string filename;

        public int Id { get; set; }
        [Required(ErrorMessage ="Name Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email Required")]
        public string Email { get; set; }
        [MinLength(6)]
        public string Password { get; set; }

        public string Image { get; set; }

        public Student(string name, string email, string password, string image)
        {
            Name = name;
            Email = email;
            Password = password;
            Image = image;
        }
    }
}

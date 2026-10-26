using System.ComponentModel.DataAnnotations;

namespace LabTask2.Models
{
    public class StudentModel
    {
        public string FullName { get; set; }

        public int Age { get; set; }


        [Required]
        public string Gender { get; set; }



    }
}

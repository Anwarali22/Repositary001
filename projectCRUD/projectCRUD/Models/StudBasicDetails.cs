using System.ComponentModel.DataAnnotations;

namespace projectCRUD.Models
{
    public class StudBasicDetails
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        //public DateOnly DOB { get; set; }

    }
}

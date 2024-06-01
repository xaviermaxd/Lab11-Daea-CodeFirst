using System.ComponentModel.DataAnnotations;

namespace lab11_DAEA.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }
        
    }
}

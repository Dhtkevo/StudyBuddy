using System.ComponentModel.DataAnnotations;

namespace StudyBuddy.Models
{
    /// <summary>
    /// Model class that represents a course
    /// </summary>
    public class Course
    {
        public int Id { get; set; }
        [Display(Name = "Course Name")]
        [StringLength(30, MinimumLength = 10)]
        [Required]
        public string? Name { get; set; }

        [StringLength(20, MinimumLength = 4)]
        [Required]
        public string? Subject { get; set; }

        public string? Description { get; set; }
    }
}

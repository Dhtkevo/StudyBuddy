using System.ComponentModel.DataAnnotations;

namespace StudyBuddy.Models
{
    /// <summary>
    /// Model class that represents a course
    /// </summary>
    public class Course
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Display(Name = "Course Name")]
        [StringLength(30, MinimumLength = 5)]
        [Required]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        /// <value>
        /// The subject.
        /// </value>
        [StringLength(20, MinimumLength = 4)]
        [Required]
        public string? Subject { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>        
        public string? Description { get; set; }
    }
}

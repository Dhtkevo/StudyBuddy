using System.ComponentModel.DataAnnotations;

namespace StudyBuddy.Models
{
    /// <summary>
    /// Class that represents a task
    /// </summary>
    public class Task
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the task.
        /// </summary>
        /// <value>
        /// The name of the task.
        /// </value>
        [Required]
        public string? TaskName { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        public DateTime? EndDate { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc.Rendering;

namespace StudyBuddy.Models;

/// <summary>
/// View model for course subjects
/// </summary>
public class CourseSubjectViewModel
{
    /// <summary>
    /// Gets or sets the courses.
    /// </summary>
    /// <value>
    /// The courses.
    /// </value>
    public List<Course>? Courses { get; set; }
    /// <summary>
    /// Gets or sets the subjects.
    /// </summary>
    /// <value>
    /// The subjects.
    /// </value>
    public SelectList? Subjects { get; set; }
    /// <summary>
    /// Gets or sets the course subject.
    /// </summary>
    /// <value>
    /// The course subject.
    /// </value>
    public string? CourseSubject { get; set; }
    /// <summary>
    /// Gets or sets the search string.
    /// </summary>
    /// <value>
    /// The search string.
    /// </value>
    public string? SearchString { get; set; }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudyBuddy.Models;

namespace StudyBuddy.Data
{
    public class StudyBuddyContext : DbContext
    {
        public StudyBuddyContext (DbContextOptions<StudyBuddyContext> options)
            : base(options)
        {
        }

        public DbSet<StudyBuddy.Models.Course> Course { get; set; } = default!;

        public DbSet<StudyBuddy.Models.Tasks> Tasks { get; set; } = default!;
    }
}

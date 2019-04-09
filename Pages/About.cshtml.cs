using ContosoUniversity.Models.SchoolViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Models;
using System;

namespace ContosoUniversity.Pages
{
    public class AboutModel : PageModel
    {
        private readonly SchoolContext _context;

        public AboutModel(SchoolContext context)
        {
            _context = context;
        }

        public IList<EnrollmentDateGroup> EnrollmentDates { get; set; }
        public IList<GradesDataGroup> AvgGrades { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<EnrollmentDateGroup> data_EnrollmentDates =
                from student in _context.Students
                group student by student.EnrollmentDate into dateGroup
                select new EnrollmentDateGroup()
                {
                    EnrollmentDate = dateGroup.Key,
                    StudentCount = dateGroup.Count()
                };

            EnrollmentDates = await data_EnrollmentDates.AsNoTracking().ToListAsync();

            IQueryable<GradesDataGroup> data_AvgGrades =
                from enrollment in _context.Enrollments
                group enrollment by enrollment.Course into courseGroup
                select new GradesDataGroup()
                {
                    CourseTitle = courseGroup.Key.Title,
                    AvgGrade = CalcAvgGrade(courseGroup)
                };

            AvgGrades = await data_AvgGrades.AsNoTracking().ToListAsync();
        }

        private string CalcAvgGrade(IEnumerable<Enrollment> enrolments)
        {
            var completedGrades = enrolments.Where(x => x.Grade != null);
            if(!completedGrades.Any())
            {
                return string.Empty;
            }

            var gpa = completedGrades.Select(x => (int)x.Grade.GetValueOrDefault()).Average();
            string modifier = gpa % 1 >= 0.75 ? "-" : gpa % 1 >= 0.5 ? "-" : string.Empty;
            switch((int)Math.Floor(gpa+0.25))
            {
                case 4:
                    return $"A{modifier}";
                case 3:
                    return $"B{modifier}";
                case 2:
                    return $"C{modifier}";
                case 1:
                    return $"D{modifier}";
                case 0:
                    return "F";
                default:
                    return string.Empty;
            }
        }
    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models.SchoolViewModels
{
    public class GradesDataGroup
    {
        [DataType(DataType.Date)]
        public string CourseTitle { get; set; }

        public string AvgGrade { get; set; }
    }
}
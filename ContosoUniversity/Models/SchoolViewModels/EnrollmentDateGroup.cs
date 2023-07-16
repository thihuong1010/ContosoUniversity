using System;
using System.ComponentModel.DataAnnotations;

// Create a view model class for the data that need to pass to the view
namespace ContosoUniversity.Models.SchoolViewModels
{
	public class EnrollmentDateGroup
	{
		[DataType(DataType.Date)]
		public DateTime? EnrollmentDate { get; set; }

		public int StudentCount { get; set; }
	}
}


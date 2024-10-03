using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
	public class Student : Person
	{
		public string StudentId { get; set; }

		public string School { get; set; }

		public int StartingTime { get; set; }

		public double AverageScore { get; set; }

		public AcademicPerformanceRatingEnum APR { get; set; }

		public Student()
		{

		}

		public Student(string name, DateTime dob, string address, float height, float weight, string studentId, string school, int startingTime, double averageScore) : base(name, address, dob, height, weight)
		{
			StudentId = studentId;
			School = school;
			StartingTime = startingTime;
			AverageScore = averageScore;
			UpdateAcademicPerformance();
		}

		public override string ToString()
		{
			base.ToString();
			return $"| StudentInfo | StudentId <{StudentId}> School <{School}> StartingTime <{StartingTime}> AverageScore <{AverageScore}> |";
		}

		private void UpdateAcademicPerformance()
		{
			APR = AverageScore switch
			{
				< 3 => AcademicPerformanceRatingEnum.Poor,
				>= 3 and < 5 => AcademicPerformanceRatingEnum.Weak,
				>= 5 and < 6.5 => AcademicPerformanceRatingEnum.Average,
				>= 6.5 and < 7.5 => AcademicPerformanceRatingEnum.Well,
				>= 7.5 and < 9 => AcademicPerformanceRatingEnum.Good,
				_ => AcademicPerformanceRatingEnum.Excellent,
			};
		}
	}
}

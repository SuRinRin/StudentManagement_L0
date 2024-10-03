using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
	public class Person
	{
		private static int _AutoId = 1;
		public int PersonId { get; set; }

		public string Name { get; set; }

		public DateTime DateOfBirth { get; set; }

		public string Address { get; set; }

		public float Height { get; set; }

		public float Weight { get; set; }

		public Person()
		{

		}

		public Person(string name, string address, DateTime dateOfBirth, float height, float weight)
		{
			PersonId = _AutoId++;
			Name = name;
			Address = address;
			DateOfBirth = dateOfBirth;
			Height = height;
			Weight = weight;
		}

		public virtual string ToString()
		{
			return $"| PersonInfo | PersonId <{PersonId}> | Name <{Name}> Address <{Address}> DOB <{DateOfBirth}> Height <{Height}>(cm) Weight <{Weight}>(kg) |"; ;
		}
	}
}

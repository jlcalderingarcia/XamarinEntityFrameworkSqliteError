using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.EF.Model
{
	public class SampleEntity
	{
		[Key]
		public int Id { get; set; }

		[MaxLength(200)]
		public string Name { get; set; }
	}
}

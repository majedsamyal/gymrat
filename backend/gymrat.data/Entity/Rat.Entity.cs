using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gymrat.Data.Entity
{
	[Table("Rat")]
	public class Rat
    {
		public string Id { get; set; }
		public string EmailId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public bool IsActive { get; set; }
		public bool IsDeleted { get; set; }
		public DateTime CreatedDateTime { get; set; }
		public DateTime UpdateDateTime { get; set; }
	}
}

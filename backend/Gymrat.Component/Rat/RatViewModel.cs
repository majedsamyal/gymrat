using System;
using System.Collections.Generic;
using System.Text;

namespace Gymrat.Component.Rat
{
   public class RatViewModel
    {
		public string Id { get; set; }
		public string EmailId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public bool IsActive { get; set; }
		public bool IsDeleted { get; set; }
		public string CreatedDateTime { get; set; }
		public string UpdateDateTime { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Model
{
    public class UserDetails
    {
		[Key]
		public int UserID { get; set; }
		[Column(TypeName = "varchar(50)")]
		public string UserName { get; set; }
		[Column(TypeName = "varchar(50)")]
		public string EmailId { get; set; }
		[Column(TypeName = "char(10)")]
		public string Gender { get; set; }
		
		[Column(TypeName = "varchar(500)")]
		public string Address { get; set; }

		[Column(TypeName = "varchar(50)")]
		public string MobileNo { get; set; }
		[Column(TypeName = "varchar(50)")]
		public string PinCode { get; set; }		
	}
}

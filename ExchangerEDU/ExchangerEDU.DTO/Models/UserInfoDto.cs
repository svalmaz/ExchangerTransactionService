using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangerEDU.DTO.Models
{
	public class UserInfoDto
	{
		public string Name { get; set; } = string.Empty;
		public string Surname { get; set; } = string.Empty;
		public DateTime BirthDate { get; set; }
		public bool VerificationStatus { get; set; } = false;
		public string ImageUrl { get; set; } = string.Empty;

	
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangerEDU.DataAccess.Models
{
	public class UserEntity
	{
		public Guid Id { get; set; }
		public string Email { get; set; } = string.Empty;
		public string Password { get; set; } = string.Empty;
		
		//ref to userinfo
		public Guid UserInfoId { get; set; }
		public UserInfoEntity? UserInfo {  get; set; }
		//ref to wallet
		public List<WalletEntity> Wallets { get; set; } = [];
	}
}

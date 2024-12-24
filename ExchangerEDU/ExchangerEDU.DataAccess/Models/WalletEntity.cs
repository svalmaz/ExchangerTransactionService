namespace ExchangerEDU.DataAccess.Models
{
	public class WalletEntity
	{
		public Guid Id { get; set; }
		public string Address { get; set; } = string.Empty;
		public decimal Balance { get; set; } = decimal.Zero;


		//ref to user
		public Guid UserId { get; set; }
		public UserEntity? User { get; set; }
		//ref to coin
		public Guid CoinId { get; set; }
		public CoinEntity? Coin { get; set; }	
		
	}
}

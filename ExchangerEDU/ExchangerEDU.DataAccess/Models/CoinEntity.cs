namespace ExchangerEDU.DataAccess.Models
{
	public class CoinEntity
	{
		public Guid Id { get; set; }
		public string CoinName { get; set; } = string.Empty;
		public string CoinCode { get; set; } = string.Empty;
		public string ImageUrl { get; set; } = string.Empty;

		//ref to wallet
		public List<WalletEntity> Wallets { get; set; } = [];
	}
}

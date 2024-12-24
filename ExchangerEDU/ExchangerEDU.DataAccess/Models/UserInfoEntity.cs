namespace ExchangerEDU.DataAccess.Models
{
	public class UserInfoEntity
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Surname { get; set; } = string.Empty;
		public DateTime BirthDate { get; set; }
		public bool VerificationStatus { get; set; } =false;
		public string ImageUrl { get; set; } = string.Empty;

		//ref to our user
		public Guid UserId { get; set; }
		public UserEntity User { get; set; }

	}
}

using ExchangerEDU.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExchangerEDU.DataAccess.Confifgurations
{
	public class UsersInfoConfiguration : IEntityTypeConfiguration<UserInfoEntity>
	{
		public void Configure(EntityTypeBuilder<UserInfoEntity> builder)
		{
			builder.HasKey(u => u.Id);
			builder.HasOne(u => u.User)
				.WithOne(u => u.UserInfo)
				.HasForeignKey<UserInfoEntity>(u => u.UserId);


		}
	}
}

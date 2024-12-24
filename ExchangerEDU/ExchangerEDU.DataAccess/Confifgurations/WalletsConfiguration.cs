using ExchangerEDU.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExchangerEDU.DataAccess.Confifgurations
{
	public class WalletsConfiguration : IEntityTypeConfiguration<WalletEntity>
	{
		public void Configure(EntityTypeBuilder<WalletEntity> builder)
		{
			builder.HasKey(u => u.Id);

			builder.HasOne(w => w.User)
				.WithMany(u => u.Wallets);

			builder.HasOne(w => w.Coin)
			.WithMany(c => c.Wallets);
		}
	}
}

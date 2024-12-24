using ExchangerEDU.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExchangerEDU.DataAccess.Confifgurations
{
	public class CoinsConfiguration : IEntityTypeConfiguration<CoinEntity>
	{
		public void Configure(EntityTypeBuilder<CoinEntity> builder)
		{
			builder.HasKey(u => u.Id);
		

			builder.HasMany(u => u.Wallets)
				.WithOne(w => w.Coin);
		}
	}
}

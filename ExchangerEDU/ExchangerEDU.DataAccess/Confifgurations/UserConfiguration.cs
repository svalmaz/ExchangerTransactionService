using ExchangerEDU.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangerEDU.DataAccess.Confifgurations
{
	public class UsersConfiguration : IEntityTypeConfiguration<UserEntity>
	{
		public void Configure(EntityTypeBuilder<UserEntity> builder)
		{
			builder.HasKey(u => u.Id);
			builder.HasOne(u => u.UserInfo)
				.WithOne(u => u.User)
				.HasForeignKey<UserInfoEntity>(u => u.UserId);


			builder.HasMany(u => u.Wallets)
				.WithOne(w => w.User);
		}
	}
}

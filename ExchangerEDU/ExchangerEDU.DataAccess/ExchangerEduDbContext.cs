using ExchangerEDU.DataAccess.Confifgurations;
using ExchangerEDU.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangerEDU.DataAccess
{
	public class ExchangerEduDbContext(DbContextOptions<ExchangerEduDbContext> options) : DbContext(options)
	{



		public DbSet<UserEntity> Users { get; set; }
		public DbSet<UserInfoEntity> UsersInfo { get; set; }
		public DbSet<WalletEntity> Wallets { get; set; }
		public DbSet<CoinEntity> Coins { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new UsersConfiguration());
			modelBuilder.ApplyConfiguration(new UsersInfoConfiguration());
			modelBuilder.ApplyConfiguration(new CoinsConfiguration());
			modelBuilder.ApplyConfiguration(new WalletsConfiguration());
			
			base.OnModelCreating(modelBuilder);
		}
	}
}

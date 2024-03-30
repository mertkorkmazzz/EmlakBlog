using Microsoft.EntityFrameworkCore;
using RealEstate.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.Data.Context
{
	public class AppDbContext : DbContext
	{

		public AppDbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<User> Users { get; set; }
		public DbSet<Advert> Advertis { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)//bu metot model oluşturmadan önce yapabilcemiz configrasyon sağlıyor ve MAPPİNS classını veritabanında tanımlamak için burda kullanılyor
		{

			builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());//bütün mapping sınıfları burda tanımlanır
		}
	}
}

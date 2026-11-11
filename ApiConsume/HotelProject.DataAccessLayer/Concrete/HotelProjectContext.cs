using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.DataAccessLayer.Concrete
{
	public class HotelProjectContext : IdentityDbContext<AppUser, AppRole, int>
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=UMUT\\SQLEXPRESS;initial catalog=HotelApiDb;integrated security=true");
		}

		public DbSet<Room> Rooms { get; set; }
		public DbSet<Service> Services { get; set; }
		public DbSet<Staff> Staffs { get; set; }
		public DbSet<Subscribe> Subscribes { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
		public DbSet<About> Abouts { get; set; }
		public DbSet<Trailer> Trailers { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<SocialMedia> SocialMedias { get; set; }
		public DbSet<Booking> Bookings { get; set; }
	}
}

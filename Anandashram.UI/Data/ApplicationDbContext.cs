using Microsoft.EntityFrameworkCore;
using Anandashram.Models;


namespace Anandashram.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Anandashram.Models.Block> Blocks { get; set; }
        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<Floor> Floors { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<DevoteeCategory> DevoteeCategories { get; set; }
        public virtual DbSet<Devotee> Devotees { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }

    }
}

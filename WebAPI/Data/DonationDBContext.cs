using Microsoft.EntityFrameworkCore;
using WebAPI.Models;


namespace WebAPI.Data
{
    public class DonationDBContext : DbContext
    {
        public DonationDBContext(DbContextOptions<DonationDBContext> options)
            : base(options)
        {
        }

        public DbSet<DCandidate> dCandidates { get; set; }
    }
}

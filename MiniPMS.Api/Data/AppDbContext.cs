using Microsoft.EntityFrameworkCore;
using MiniPMS.Api.Models;

namespace MiniPMS.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<DuAn> DuAn { get; set; }
    public DbSet<CongViec> CongViec { get; set; }
}

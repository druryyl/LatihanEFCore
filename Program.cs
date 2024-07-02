using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace LatihanEFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class AgamaModel
    {
        [Column("fs_kd_agama")]
        public string AgamaId { get; set; }
        [Column("fs_nm_agama")]
        public string AgamaName { get; set; }
    }

    public class DataSosialDbContext : DbContext
    {
        public DbSet<AgamaModel> Agama { get; set; }
        
        public DataSosialDbContext(DbContextOptions<DataSosialDbContext> options) : base(options)
        {
        }
        public override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=LatihanEFCore;Trusted_Connection=True;");
        }
    }
}

using GameInterface.Domain.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GameInterface.Domain.Repositories.Repositories
{
    public class GameInterfaceDbContext : DbContext
    {
        public GameInterfaceDbContext()
            : base("name=GIConnection")
        {
 
        }

        public DbSet<AppCategory> AppCategorys { get; set; }

        public DbSet<AppInfo> AppInfos { get; set; }

        public DbSet<DownloadInfo> DownloadInfos { get; set; }

        public DbSet<User> Users { get; set; }
    }
}

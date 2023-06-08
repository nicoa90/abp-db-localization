using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Localization.EntityFrameworkCore
{
    [ConnectionStringName("Localization")]
    public class LocalizationDbContext : AbpDbContext<LocalizationDbContext>, ILocalizationDbContext
    {
        public LocalizationDbContext(DbContextOptions<LocalizationDbContext> options) : base(options)
        {
        }

        public DbSet<LocalizedResource> LocalizedResources { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


        }
    }

    public interface ILocalizationDbContext : IEfCoreDbContext
    {
        DbSet<LocalizedResource> LocalizedResources { get; }
    }


}

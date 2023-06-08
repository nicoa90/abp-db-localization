using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Localization.EntityFrameworkCore
{
    public static class LocalizationDbContextModelCreatingExtensions
    {
        public static void ConfigureLocalization(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));
            builder.Entity<LocalizedResource>(b =>
            {
                b.ToTable("LocalizedResources");
                b.ConfigureByConvention();
            });
        }
    }
}

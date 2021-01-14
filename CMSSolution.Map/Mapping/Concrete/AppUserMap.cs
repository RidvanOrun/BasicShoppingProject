using CMSSolution.Entity.Entities.Concrete;
using CMSSolution.Map.Mapping.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSolution.Map.Mapping.Concrete
{
    public class AppUserMap:BaseMap<AppUser>
    {

        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Occupation).IsRequired(true);
            base.Configure(builder);
        }

    }
}

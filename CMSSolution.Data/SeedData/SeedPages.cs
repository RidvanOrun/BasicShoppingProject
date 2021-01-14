using CMSSolution.Entity.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMSSolution.Data.SeedData
{
    public class SeedPages : IEntityTypeConfiguration<Page>
    {
        public void Configure(EntityTypeBuilder<Page> builder)
        {
            //Database 'de tek tek manuel olarak girmemek adı altında tohumlama yapılarak verileri database de bulunan page tablosuna gönderdik.
            // Oluşturacağımız projenin datalarını örneklem olması açısından tohumlama ile göndeririz.
            builder.HasData(
                new Page { Id = 1, Title = "Home", Content = "Home Page", Slug = "home-page", Sorting = 100 },
                new Page { Id = 2, Title = "Abouth Us", Content = "About US Page", Slug = "about-page", Sorting = 100 },
                new Page { Id = 3, Title = "Services", Content = "Services Page", Slug = "service-page", Sorting = 100 },
                new Page { Id = 4, Title = "Contanct Us", Content = "Contanct Us Page", Slug = "contact-page", Sorting = 100 }
                );
        }
    }
}

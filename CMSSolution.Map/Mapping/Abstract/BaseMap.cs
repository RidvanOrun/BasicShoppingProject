using CMSSolution.Entity.Entities.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMSSolution.Map.Mapping.Abstract
{
    //IEntityTypeConfiguration'dan Configure methodu kalıtım olarak gelir. Varlıkları,özelliklerini ve Varlık İlişkilerini veritabanına eşlemek için kullanılır. .netCoreda bulunan hazır ınterfacelerdendir.
    public abstract class BaseMap<T> : IEntityTypeConfiguration<T> where T : class, IBaseEntity
    {   //class; normalde where T: den sonra somut bir sınıf yazılması gerekir IBaseEntity interface olduğundan yanına class iafedesi eklendi.
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            //Standart .net'de mapping işlemleri consturactor methodların içerisinde yapılır. Burada Core'a özel olan ve IEntityTypeConfiguration'dan gelen Configure methodunun içerisinde yapılır.

            builder.Property(x => x.CreateDate).IsRequired(true);
            builder.Property(x => x.UpdateDate).IsRequired(false);
            builder.Property(x => x.DeleteDate).IsRequired(false);
            builder.Property(x => x.Status).IsRequired(true);
        }
    }
}

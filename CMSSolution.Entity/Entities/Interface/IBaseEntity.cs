using CMSSolution.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMSSolution.Entity.Entities.Interface
{
    public interface IBaseEntity
    {
        DateTime CreateDate { get; set; }
        DateTime? UpdateDate { get; set; }
        DateTime? DeleteDate { get; set; }
        Status Status { get; set; }

    }
}

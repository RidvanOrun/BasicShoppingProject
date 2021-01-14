using CMSSolution.Data.Repositories.Interface.Base;
using CMSSolution.Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMSSolution.Data.Repositories.Interface.EntityRepository
{
    public interface IAppUserRepository : IKernelRepository<AppUser>
    {
    }
}

using CMSSolution.Data.Context;
using CMSSolution.Data.Repositories.Concrete.Base;
using CMSSolution.Data.Repositories.Interface.EntityRepository;
using CMSSolution.Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMSSolution.Data.Repositories.Concrete.EntityTypeRepository
{
    public class PageRepository:KernelRepository<Page>,IPageRepository
    {
        public PageRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext) { }
    }
}

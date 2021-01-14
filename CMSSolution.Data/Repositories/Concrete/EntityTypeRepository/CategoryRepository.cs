using CMSSolution.Data.Context;
using CMSSolution.Data.Repositories.Concrete.Base;
using CMSSolution.Data.Repositories.Interface.EntityRepository;
using CMSSolution.Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMSSolution.Data.Repositories.Concrete.EntityTypeRepository
{
    public class CategoryRepository:KernelRepository<Category>,ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext) { }
    }
}

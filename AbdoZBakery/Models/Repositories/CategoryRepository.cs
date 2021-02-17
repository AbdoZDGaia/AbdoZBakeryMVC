using AbdoZBakery.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbdoZBakery.Models.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDBContext _ctx;

        public CategoryRepository(AppDBContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Category> AllCategories => _ctx.Categories;
    }
}

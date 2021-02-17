using AbdoZBakery.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbdoZBakery.Models.Repositories
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDBContext _ctx;

        public PieRepository(AppDBContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Pie> AllPies => _ctx.Pies.Include(p => p.Category);

        public IEnumerable<Pie> PiesOfTheWeek => _ctx.Pies.Include(p => p.Category).Where(p => p.IsPieOfTheWeek);

        public Pie GetPieById(int pieId)
        {
            var result = _ctx.Pies.Find(pieId);
            return result;
        }
    }
}

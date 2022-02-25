using JarbasMoney.Domain.Entities;
using JarbasMoney.Domain.Queries;
using JarbasMoney.Domain.Repositories;
using JarbasMoney.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarbasMoney.Infra.Repositories
{
    public class StockRepository : IStockRepository
    {

        private readonly DataContext _context;

        public StockRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Stock> GetAll()
        {
            return _context.Stocks
               .AsNoTracking()
               .Where(StockQueries.GetAll())
               ;
        }


    }
}

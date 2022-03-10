using JarbasMoney.Domain.Entities;
using System;
using System.Linq.Expressions;


namespace JarbasMoney.Domain.Queries
{
    public static class StockQueries
    {

        public static Expression<Func<Stock, bool>> GetAll()
        {
            return x => x == x;
        }
    }
}

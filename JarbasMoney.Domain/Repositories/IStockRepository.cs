using JarbasMoney.Domain.Entities;
using System.Collections.Generic;

namespace JarbasMoney.Domain.Repositories
{
    public interface IStockRepository
    {
        IEnumerable<Stock> GetAll();

    }
}

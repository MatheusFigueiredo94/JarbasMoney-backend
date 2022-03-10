using JarbasMoney.Domain.Entities;
using System.Collections.Generic;

namespace JarbasMoney.Domain.Repositories
{
    public interface IStockRepository
    {
        List<Stock> GetAll();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarbasMoney.Domain.Entities
{
    public class Stock : Entity
    {
        public Stock(string stockCode)
        {
            StockCode = stockCode;
        }
        public string StockCode { get; set; } 
    }
}

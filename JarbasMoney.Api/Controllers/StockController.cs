using JarbasMoney.Domain.Entities;
using JarbasMoney.Domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace JarbasMoney.Api.Controllers
{
    [ApiController]
    [Route("v1/stock")]
    //[Authorize]
    public class StockController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public List<Stock> GetAll(
            [FromServices] IStockRepository repository
        )
        {
            //var user = User.Claims.FirstOrDefault(x => x.Type == "user_id")?.Value;
            return repository.GetAll();
        }
    }
}

using CoinJarBLL.eNums;
using CoinJarBLL.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GK_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoinJarController : ControllerBase
    {
        private readonly ILogger<CoinJarController> logger;
        private readonly ICoinJar coinJarService;

        public CoinJarController(ILogger<CoinJarController> logger, ICoinJar coinJar)
        {
            this.logger = logger;
            this.coinJarService = coinJar;
        }

        [HttpPost]
        [Route("AddCoin")]
        public void AddCoin(enumCoinType coinType, int count = 1)
        {
            this.coinJarService.AddCoin(coinType, count);
        }
        [HttpGet]
        [Route("GetAmount")]

        public decimal Amount()
        {
            return this.coinJarService.GetTotalAmount();
        }

        [HttpPost]
        [Route("ResetJar")]

        public void Reset()
        {
            this.coinJarService.Reset();
        }
    }
}

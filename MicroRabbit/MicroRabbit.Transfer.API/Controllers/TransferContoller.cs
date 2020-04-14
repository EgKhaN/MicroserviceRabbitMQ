using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MicroRabbit.Transfer.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransferContoller : ControllerBase
    {
       
        private readonly ILogger<TransferContoller> _logger;
        private readonly ITransferService _transferService;

        public TransferContoller(ILogger<TransferContoller> logger , ITransferService transferService)
        {
            _logger = logger;
            _transferService = transferService;
        }

        [HttpGet]
        public ActionResult<List<TransferLog>> Get()
        {
            return Ok(_transferService.GetTransferLogs());
        }
    }
}

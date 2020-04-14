﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MicroRabbit.Banking.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankingController : ControllerBase
    {
        private readonly ILogger<BankingController> _logger;
        private readonly IAccountService accountService;

        public BankingController(ILogger<BankingController> logger , IAccountService accountService)
        {
            _logger = logger;
            this.accountService = accountService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(accountService.GetAccounts());
        }

        [HttpPost]
        public IActionResult Post([FromBody]AccountTransfer accountTransfer)
        {
            accountService.Transfer(accountTransfer);
            return Ok(accountTransfer);
        }
    }
}

﻿using HelloEmpty.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloEmpty.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public List<HelloMessage> Get()
        {
            List<HelloMessage> messages = new List<HelloMessage>();

            messages.Add(new HelloMessage() { Message = "Hello Web Api 1 !" });
            messages.Add(new HelloMessage() { Message = "Hello Web Api 2 !" });
            messages.Add(new HelloMessage() { Message = "Hello Web Api 3 !" });

            return messages;
        }
    }
}

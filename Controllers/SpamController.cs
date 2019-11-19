using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SpamAPI.Models;

namespace SpamAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpamController : ControllerBase
    {
        private Context context;
        public SpamController(Context context)
        {
            this.context = context;
        }

    }
}

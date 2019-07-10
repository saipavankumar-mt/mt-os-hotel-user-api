using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreContracts.Model.Login;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UserOrderingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public LoginController()
        {

        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] UserInfo user)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }
    }
}
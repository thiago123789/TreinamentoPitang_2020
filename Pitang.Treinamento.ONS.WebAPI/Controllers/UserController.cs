using System;
using Microsoft.AspNetCore.Mvc;
using Pitang.Treinamento.ONS.Services;

namespace Pitang.Treinamento.ONS.WebAPI.Controllers
{
    //GET http://localhost:50100/user/api
    [Route("[controller]/api")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public void Get([FromServices] IUserService userService)
        {
            string parametro = null;
            if (parametro == null)
            {
               
            }
        }

        //GET http://localhost:50100/user/api/getOne
        [HttpGet("getOne")]
        public void GetOne()
        {

        }
    }
}

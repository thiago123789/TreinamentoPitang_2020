using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pitang.Treinamento.ONS.Entities;
using Pitang.Treinamento.ONS.Services;
using Pitang.Treinamento.ONS.WebAPI.DTOs;

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


        [HttpPut]
        public void Put([FromBody] PropertyUpdateDTO inputDto)
        {
            var user = new Aluno();
            user.Id = inputDto.ObjectId;

            foreach (var property in inputDto.PropertiesToUpdate)
            {
                var propertyInfo = typeof(Aluno).GetProperty(property.PropertyName);
                var typeParameter = propertyInfo.GetType();

                //Olhar https://codereview.stackexchange.com/questions/126405/generic-extension-method-that-will-attempt-to-parse-a-string-and-return-its-val

                propertyInfo.SetValue(user, property.PropertyValue);
            }
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

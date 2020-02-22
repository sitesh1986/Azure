using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Common.Repository.ViewModel;
using Manager.Repository.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DbModel;

namespace AzureProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class B2CUserController : ControllerBase
    {
        private GraphUserManager _graphUserManager;
        public B2CUserController(GraphUserManager graphUserManager)
        {
            _graphUserManager = graphUserManager;
        }
        [HttpPost]
        public async Task<IActionResult> Create(UserViewModel userViewModel)
        {
            var mappedUser = Mapper.Map<UserViewModel, UserModel>(userViewModel);
            var created=await _graphUserManager.CreateB2CUser(mappedUser);
            return Ok(created);
        }
    }
}

using AutoMapper;
using Common.Repository.ViewModel;
using Models.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureProject.App_Start
{
    public class ModelMapper
    {
       public static void Intialize()
        {
            Mapper.Initialize((config) =>
            {
                config.CreateMap<UserViewModel, UserModel>();
            });
        }
    }
}

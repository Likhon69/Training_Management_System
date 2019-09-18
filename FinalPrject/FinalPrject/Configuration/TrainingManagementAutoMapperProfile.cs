using AutoMapper;
using FinalPrject.Models.TraineeVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingManagement.Model;

namespace FinalPrject.Configuration
{
    public class TrainingManagementAutoMapperProfile:Profile
    {
        public TrainingManagementAutoMapperProfile()
        {
            CreateMap<TraineeCreateVm, Trainee>();
            CreateMap<Trainee, TraineeCreateVm>();
        }
    }
}

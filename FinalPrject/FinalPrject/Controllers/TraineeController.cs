using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FinalPrject.Models.TraineeVm;
using FinalPrject.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TrainingManagement.Database.Database;
using TrainingManagement.Manager;
using TrainingManagement.Manager.Contracts;
using TrainingManagement.Model;

namespace FinalPrject.Controllers
{
    public class TraineeController : Controller
    {
        private ITraineeManager _traineeManager;
        private IMapper _mapper;
        private IDepartmentManager _departmentManager;
        private IUtitlityManager _utilityManager;
        public TraineeController(ITraineeManager traineeManager,IMapper mapper,IDepartmentManager departmentManager,IUtitlityManager utitlityManager)
        {
            _traineeManager = traineeManager;
            _mapper = mapper;
            _departmentManager = departmentManager;
            _utilityManager = utitlityManager;
        }
        
        [HttpGet]
        public IActionResult Trainee()
        {
            var model = new TraineeCreateVm();
            model.TraineeList = _traineeManager.GetAll();
            model.DepartmentLookUpData = _utilityManager.GetDepartmentLookUpData();
            return View(model);
        }
        [HttpPost]
        public IActionResult Trainee(TraineeCreateVm model)
        {
            
            if (ModelState.IsValid)
            {
                var trainee = _mapper.Map<Trainee>(model);
                
                bool Issucces = _traineeManager.Add(trainee);
                if (Issucces)
                {
                    
                }
                //model.TraineeList = _traineeManager.GetAll();

            }
            model.TraineeList = _traineeManager.GetAll();
            model.DepartmentLookUpData = _utilityManager.GetDepartmentLookUpData();
            return View(model);
        }
        public JsonResult GetByDepartmentJsonResult(int departmentId)
        {
            var traineeList = _traineeManager.GetByDepartment(departmentId);
            return Json(traineeList);

        }
        public PartialViewResult GetByDepartmentPartial(int departmentId)
        {
            var traineeList = _traineeManager.GetByDepartment(departmentId);
            return PartialView("_TraineeList", traineeList);
        }
        public JsonResult GetAllDepartmentJsonResult()
        {
            var departments = _departmentManager.GetAll();
            return Json(departments);
           
        }
    }
}
﻿using Microsoft.AspNetCore.Mvc;
using Silas.Models.Companies;

namespace Silas.Controllers
{
    public class CompanyController : Controller
    {


        //SERVICIO DE LAS COMPAÑIAS
        private readonly CompanyService _companyService;

        //CONSTRUCTOR PARA EL CONTROLADOR
        public CompanyController (CompanyService companyService)
        {
            _companyService = companyService;
        }





        public IActionResult Index()
        {
            return View();
        }
    }
}

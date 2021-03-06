﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MvvmApplication.Models;
using MvvmApplication.Services;

namespace MvvmApplication.Controllers.Apis
{
    public class BrandController : ApiController
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        // GET api/company
        public IEnumerable<Brand> Get()
        {
            return _brandService.GetAll();
        }

        // GET api/company
        public Brand GetBrand(long id)
        {
            return _brandService.GetBrand(id);
        }

        //this function is not wokring
        //need to parse json info
        public HttpResponseMessage Post([FromBody] Brand brand)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.Accepted,
                    "Trying to Add a brand into db with the following info: " + brand.Name);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
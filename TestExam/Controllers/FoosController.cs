﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entities;
namespace TestExam.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FoosController : ControllerBase
    {
        private IEnumerable<Foo> FoosDataSet { get; set; }

        public FoosController()
        {
            //Filled with random data for demostration purposes

            var fooList = new List<Foo>();

            for (int i = 1; i <= 100; i++)
            {
                fooList.Add(new Foo
                {
                    Id = i,
                    Col1 = $"col1 row{i}",
                    Col2 = i*10,
                    Col3 = i*100,
                    Col4 = i*1000
                });
            }

            FoosDataSet = fooList;
        }


        [HttpGet]
        public IEnumerable<Foo> Get()
        {
            var fooList = FoosDataSet.ToArray();
            return fooList;
        }

    }
}

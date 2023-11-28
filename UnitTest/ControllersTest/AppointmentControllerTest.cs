using Microsoft.AspNetCore.Mvc;
using ProjectOrthodontics.Controllers;
using ProjectOrthodontics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTest.ControllersTest
{
    public class AppointmentControllerTest
    {
        private readonly AppointmentController _appointmentController;


        public AppointmentControllerTest()
        {
            var context = new DataContextFake();

            _appointmentController = new AppointmentController(context);
        }
        [Fact]
        public void Get_IsReturnsOk()
        {
            var result = _appointmentController.Get() as OkObjectResult;

            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void Get_allItems()
        {
            var result = _appointmentController.Get() as OkObjectResult;

            var list = Assert.IsType<List<Appointment>>(result.Value);

            Assert.Equal(1, list.Count);
        }
        [Fact]
        public void GetById_UnknownCode_ReturnsNotFoundResult()
        {
            // Act
            var notFoundResult = _appointmentController.Get(6);
            // Assert
            Assert.IsType<NotFoundResult>(notFoundResult);
        }
        [Fact]
        public void GetById_ExistingCode_ReturnsOkResult()
        {
           
            // Act
            var okResult =_appointmentController.Get(1);
            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }
        [Fact]
        public void GetById_ExistingGuidPassed_ReturnsRightItem()
        {
            
           
            // Act
            var okResult = _appointmentController.Get(1) as OkObjectResult;
            // Assert
            Assert.IsType<Appointment>(okResult.Value);
            Assert.Equal(1, (okResult.Value as Appointment).CodeA);
        }
        [Fact]
        public void Post_whenCalled_ReturnsOk()
        {
            Appointment eventItem = new Appointment()
            {
                CodeA = 2,

                AppointmentName = "kj",

                AppointmentDate = DateTime.Now,

                AppointmentDuration = DateTime.Now,

                AppointmentStartTime = DateTime.Now,

                SerialNumber = 2,

                Documenting = 3
            };
            var result = _appointmentController.Post(eventItem) as OkObjectResult;

            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void Post_IsAddedToList()

        {
            var result = _appointmentController.Get() as OkObjectResult;
            var list = Assert.IsType<List<Appointment>>(result.Value);
            int c = list.Count;

            Appointment eventItem = new Appointment()
            {
                CodeA = 3,

                AppointmentName = "kjh",

                AppointmentDate = DateTime.Now,

                AppointmentDuration = DateTime.Now,

                AppointmentStartTime = DateTime.Now,

                SerialNumber = 3,

                Documenting = 4
            };
            var result2 = _appointmentController.Post(eventItem) as OkObjectResult;

            Assert.IsType<OkObjectResult>(result2);

            var result3 = _appointmentController.Get() as OkObjectResult;

            var list3 = Assert.IsType<List<Appointment>>(result.Value);

            int c3 = list.Count;

            Assert.Equal(c + 1, c3);

        }
        [Fact]
        public void Remove_ExistingGuidPassed_RemovesOneItem()
        {
            // Arrange
            var result = _appointmentController.Get() as OkObjectResult;

            var list = Assert.IsType<List<Appointment>>(result.Value);

            int c = list.Count;
            // Act
            var okResponse = _appointmentController.Delete(1);

            // Assert
            Assert.IsType<OkObjectResult>(okResponse);

            var result2 = _appointmentController.Get() as OkObjectResult;

            var list2 = Assert.IsType<List<Appointment>>(result.Value);

            int c2 = list.Count;

            Assert.Equal(c2 + 1, c);
        }
    }
}

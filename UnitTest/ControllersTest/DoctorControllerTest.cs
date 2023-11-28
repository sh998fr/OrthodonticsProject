using ProjectOrthodontics.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.ControllersTest
{
   public class DoctorControllerTest
    {
        private readonly DoctorsController _doctorsController;
        public DoctorControllerTest()
        {
            var context=new DataContextFake();
            _doctorsController = new DoctorsController(context);
        }
    }
}

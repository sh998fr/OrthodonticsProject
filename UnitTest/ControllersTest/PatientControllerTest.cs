using ProjectOrthodontics.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.ControllersTest
{
    public class PatientControllerTest
    {
        private readonly PatientcsController _patientcsController;
    public PatientControllerTest()
        {
            var context = new DataContextFake();
            _patientcsController = new PatientcsController(context);
        }

    }
}

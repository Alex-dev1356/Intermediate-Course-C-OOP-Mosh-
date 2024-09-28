using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_.Workflow_Exercise__Interface_
{
    public class CallWebServiceActivity : IActivityExercise
    {
        public void Execute()
        {
            Console.WriteLine("Calling a web service");
        }
    }
}

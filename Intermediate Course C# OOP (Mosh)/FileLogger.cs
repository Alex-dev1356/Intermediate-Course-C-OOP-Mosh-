using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Intermediate_Course_C__OOP__Mosh_
{
    //To Log our File info in a File we created this FileLogger and Implemented the Interface ILogger
    public class FileLogger : ILogger
    {
        private readonly string _path;

        //Here we create a path where we will save the Files Logged inside this constructor.
        public FileLogger(string path)
        {
           _path = path;
        }
        public void LogError(string message)
        {
            ////To write a date to a File we use the StreamWriter Method declared on the System.IO
            ////so we put the file path on the 1st argument and on the second argument true or false 
            ////if we want to append to that File, ofcourse Yes.
            //var streamWriter = new StreamWriter(_path, true);
            //streamWriter.WriteLine(message);

            ////We only have one problem and that is this stream writer USES A FILE RESOURCE. A File Resource
            ////IS NOT MANAGED by Common Language Runtime (CLR), so we need to wrap those code with "using"
            ////statement. What happens behind the scene is that, THERE IS A EXCEPTION HANDLING MECANISM INSIDE
            ////THIS "using" that we're not going to see it's implemented by the compiler. So if something goes
            ////wrong or an exception is thrown, the compiler will make sure to CLOSE HANDLE by calling the
            ////"Dispose" method on the stream writer.
            //using (var streamWriter = new StreamWriter(_path, true))
            //{
            //    streamWriter.WriteLine($"ERROR : {message}");
            //}

            //We are using here the private method Log for the princsiple of DRY.
            Log(message,"ERROR");
        }

        public void LogInfo(string message)
        {
            //We also need the same code from the LogError Method, but there is a PRINSCIPLE called DRY
            //or Do not Repeat Yourself. what we can do is we can create a PRIVATE METHOD and call it Log
            //it gets a message and perhaps get another String messagetType
            Log(message,"INFO");
        }

        //FOR DRY PRINSCIPLE
        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine($"{messageType} : {message}");
            }
        }
    }
}

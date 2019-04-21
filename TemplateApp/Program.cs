using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//add using for folders/classes you want to have in project:
using TemplateApp.FunctionClasses;

namespace TemplateApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int someNumber = 50;
            int someResult;

            //create new worker with FunctionClass blueprint
            FunctionClass functionClass = new FunctionClass();

            //asks worker to run method
            functionClass.Method();

            //asks worker to run method and gives it parameter as number
            functionClass.MethodWithParameter(50);

            //asks worker to run method and gives it parameter as variable
            functionClass.MethodWithParameter(someNumber);

            //asks worker to run method gives it parameter as number then returns it into local variable
            someResult = functionClass.MethodWithParameterAndReturn(50);

            //asks worker to run method gives it parameter as number then returns it into local variable
            someResult = functionClass.MethodWithParameterAndReturn(someNumber);

            //asks worker to run method gives it parameter as number then does math with its outcome
            someResult =100 + functionClass.MethodWithParameterAndReturn(someNumber);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

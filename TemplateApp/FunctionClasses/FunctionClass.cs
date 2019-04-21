using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateApp.FunctionClasses
{
    public class FunctionClass
    {
        //creates object from template, sets its property to 20, no parameters, returns nothing
        public void Method()
        {
            ObjectClass someObject = new ObjectClass();
            someObject.integerProperty = 20;
        }

        //creates object from template, sets its property to 20 + the parameter it's called with, returns nothing
        public void MethodWithParameter(int numberToAdd)
        {
            ObjectClass someObject = new ObjectClass();
            someObject.integerProperty = 20 + numberToAdd;
        }

        //creates object from template, sets its property to 20 + the parameter it's called with, returns the value of the property
        public int MethodWithParameterAndReturn(int numberToAdd)
        {
            ObjectClass someObject = new ObjectClass();
            someObject.integerProperty = 20 + numberToAdd;

            return someObject.integerProperty;
        }

        //creates object from template, sets its subobject property to 20, no parameters, returns nothing
        public void MethodForSubObject()
        {
            ObjectClass someObject = new ObjectClass();
            someObject.subObjectClassProperty.subIntegerProperty = 20;
        }
    }
}

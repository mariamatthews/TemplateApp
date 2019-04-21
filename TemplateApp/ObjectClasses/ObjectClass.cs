using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateApp.FunctionClasses
{
   public class ObjectClass
    {
        public int integerProperty { get; set; }
        public string stringProperty { get; set; }
        public SubObjectClass subObjectClassProperty { get; set; }
    }

    public class SubObjectClass
    {
        public int subIntegerProperty { get; set; }
        public string subStringProperty { get; set; }
    }
}

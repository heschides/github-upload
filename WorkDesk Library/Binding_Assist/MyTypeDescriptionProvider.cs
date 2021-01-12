using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkDesk_Library.Models.Employee_Info;

namespace WorkDesk_Library.Binding_Assist
{
    class MyTypeDescriptionProvider : TypeDescriptionProvider
    {
        private ICustomTypeDescriptor td;

        public MyTypeDescriptionProvider()
           : this(TypeDescriptor.GetProvider(typeof(EmployeeModel)))
        {
        }

        public MyTypeDescriptionProvider(TypeDescriptionProvider parent)
            : base(parent)
        {
        }

        public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
        {
            if (td == null)
            {
                td = base.GetTypeDescriptor(objectType, instance);
                td = new MyCustomTypeDescriptor(td);
            }
            return td;
        }
    }
}

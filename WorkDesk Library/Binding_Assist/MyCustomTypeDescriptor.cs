using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkDesk_Library.Interfaces;

namespace WorkDesk_Library.Binding_Assist
{
    class MyCustomTypeDescriptor : CustomTypeDescriptor
    {

        public MyCustomTypeDescriptor(ICustomTypeDescriptor parent)
            : base(parent)
        {
        }

        public override PropertyDescriptorCollection GetProperties()
        {
            PropertyDescriptorCollection cols = base.GetProperties();

            PropertyDescriptor JobTitle = cols["JobTitle"];

            PropertyDescriptorCollection JobTitle_child = JobTitle.GetChildProperties();

            PropertyDescriptor[] array = new PropertyDescriptor[cols.Count + 2];

            cols.CopyTo(array, 0);

            array[cols.Count] = new SubPropertyDescriptor(JobTitle, JobTitle_child["Name"], "JobTitle_Name");

            array[cols.Count + 1] = new SubPropertyDescriptor(JobTitle, JobTitle_child["ID"], "JobTitle_ID");

            PropertyDescriptorCollection newcols = new PropertyDescriptorCollection(array);

            return newcols;
        }

    }
}

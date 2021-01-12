using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDesk_Library.Interfaces
{
    class SubPropertyDescriptor : PropertyDescriptor
    {


        private PropertyDescriptor _subPD;
        private PropertyDescriptor _parentPD;

        public SubPropertyDescriptor(PropertyDescriptor parentPD, PropertyDescriptor subPD, string pdname)
            : base(pdname, null)
        {
            _subPD = subPD;
            _parentPD = parentPD;
        }

        public override Type ComponentType
        {
            get { return _parentPD.ComponentType; }
        }

        public override bool IsReadOnly { get { return false; } }

        public override Type PropertyType
        {
            get { return _subPD.PropertyType; }
        }

        public override bool CanResetValue(object component)
        {
            return false;
        }

        public override object GetValue(object component)
        {
            return _subPD.GetValue(_parentPD.GetValue(component));
        }

        public override void ResetValue(object component)
        {
        }

        public override void SetValue(object component, object value)
        {
            _subPD.SetValue(_parentPD.GetValue(component), value);
            OnValueChanged(component, EventArgs.Empty);
        }

        public override bool ShouldSerializeValue(object component)
        {
            return true;
        }
    }
}

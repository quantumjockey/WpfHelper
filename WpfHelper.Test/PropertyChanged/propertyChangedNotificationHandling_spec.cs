///////////////////////////////////////
#region Namespace Directives

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WpfHelper.PropertyChanged;

#endregion
///////////////////////////////////////

namespace WpfHelper.Test.PropertyChanged
{
    [TestClass]
    public class propertyChangedNotificationHandling_spec
    {
        ////////////////////////////////////////
        #region Unit Tests (Methods)

        [TestMethod]
        public void OnPropertyChanged_ModifyValueWhenEventInitialized_NotificationSuccessful()
        {
            TestClass _test = new TestClass();
            _test.PropertyChanged += _test_PropertyChanged;

            _test.Value = "hi";

            Assert.IsTrue(_test.HasChanged);
        }

        [TestMethod]
        public void OnPropertyChanged_ModifyValueWhenEventNotInitialized_NotificationUnSuccessful()
        {
            TestClass _test = new TestClass();

            _test.Value = "hi";

            Assert.IsFalse(_test.HasChanged);
        }

        #endregion

        ////////////////////////////////////////
        #region Child Classes (Used in Testing)

        class TestClass : propertyChangedNotificationHandling
        {
            private bool _hasChanged;
            private string _value;

            public bool HasChanged
            {
                get { return _hasChanged; }
                set { _hasChanged = value; }
            }

            public string Value
            {
                get { return _value; }
                set { _value = value; _hasChanged = OnPropertyChanged("Value"); }
            }

            public TestClass()
            {
                HasChanged = false;
                Value = String.Empty;
            }
        }

        #endregion

        ////////////////////////////////////////
        #region Supporting Methods/Events (Used in Testing)

        void _test_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            // placeholder - do nothing
        }

        #endregion
    }
}

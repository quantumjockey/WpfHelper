///////////////////////////////////////
#region Namespace Directives

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WpfHelper.ViewModel;

#endregion
///////////////////////////////////////

namespace WpfHelper.Test.ViewModel
{
    /// <summary>
    /// Unit tests addressing functionality within the "WpfHelper.ViewModel.ViewModel" class.
    /// </summary>
    [TestClass]
    public class ViewModelTest
    {
        ////////////////////////////////////////
        #region Unit Tests (Methods)

        [TestMethod]
        public void Constructor_EmptyDefaults_HeaderIsDefaultString()
        {
            TestViewModel _viewModel = new TestViewModel();

            Assert.AreEqual("App UIElement", _viewModel.Header);
        }

        [TestMethod]
        public void Constructor_EmptyDefaults_HeaderIsNotEmptyString()
        {
            TestViewModel _viewModel = new TestViewModel();

            Assert.AreNotEqual(String.Empty, _viewModel.Header);
        }

        [TestMethod]
        public void Constructor_EmptyDefaults_HeaderIsNotNull()
        {
            TestViewModel _viewModel = new TestViewModel();

            Assert.IsNotNull(_viewModel.Header);
        }

        #endregion

        ////////////////////////////////////////
        #region Child Classes (Used in Testing)

        class TestViewModel : ViewModelBase
        {
            // empty constructor so class inherits values from base constructor
            public TestViewModel() { }
        }

        #endregion
    }
}

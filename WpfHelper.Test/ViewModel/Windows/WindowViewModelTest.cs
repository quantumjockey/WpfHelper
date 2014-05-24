///////////////////////////////////////
#region Namespace Directives

using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfHelper.ViewModel.Windows;

#endregion
///////////////////////////////////////

namespace WpfHelper.Test.ViewModel.Windows
{
    [TestClass]
    public class WindowViewModelTest
    {
        ////////////////////////////////////////
        #region Unit Tests (Methods)

        [TestMethod]
        public void Constructor_EmptyDefaults_HeaderIsDefaultString()
        {
            TestWindowViewModel _viewModel = new TestWindowViewModel();

            Assert.AreEqual("App Window", _viewModel.Header);
        }

        [TestMethod]
        public void Constructor_EmptyDefaults_ViewModelIsActive()
        {
            TestWindowViewModel _viewModel = new TestWindowViewModel();

            Assert.IsTrue(_viewModel.IsActive);
        }

        [TestMethod]
        public void Constructor_EmptyDefaults_ViewModelIsNotParent()
        {
            TestWindowViewModel _viewModel = new TestWindowViewModel();

            Assert.IsFalse(_viewModel.IsParent);
        }

        #endregion

        ////////////////////////////////////////
        #region Child Classes (Used in Testing)

        class TestWindowViewModel : WindowViewModel
        {
            // empty constructor so class inherits values from base constructor
            public TestWindowViewModel() { }
        }

        #endregion
    }
}

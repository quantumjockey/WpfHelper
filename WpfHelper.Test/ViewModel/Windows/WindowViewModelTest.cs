///////////////////////////////////////
#region Namespace Directives

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WpfHelper.ViewModel.Windows;

#endregion
///////////////////////////////////////

namespace WpfHelper.Test.ViewModel.Windows
{
    /// <summary>
    /// Unit tests addressing functionality within the "WpfHelper.ViewModel.Windows.WindowViewModel" class.
    /// </summary>
    [TestClass]
    public class WindowViewModelTest
    {
        ////////////////////////////////////////
        #region Constructor (Auto-generated)

        public WindowViewModelTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        #endregion

        ////////////////////////////////////////
        #region TestContext Components (Auto-Generated)

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #endregion

        ////////////////////////////////////////
        #region Unit Tests (Methods)

        [TestMethod]
        public void Constructor_EmptyDefaults_HeaderIsDefaultString()
        {
            TestWindowViewModel _viewModel = new TestWindowViewModel();

            Assert.AreEqual("App Window", _viewModel.Header);
        }

        [TestMethod]
        public void Constructor_EmptyDefaults_HeaderIsNotEmptyString()
        {
            TestWindowViewModel _viewModel = new TestWindowViewModel();

            Assert.AreNotEqual(String.Empty, _viewModel.Header);
        }

        [TestMethod]
        public void Constructor_EmptyDefaults_HeaderIsNotNull()
        {
            TestWindowViewModel _viewModel = new TestWindowViewModel();

            Assert.IsNotNull(_viewModel.Header);
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

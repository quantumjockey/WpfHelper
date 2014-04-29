///////////////////////////////////////
#region Namespace Directives

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WpfHelper.ViewModel.Workspaces;

#endregion
///////////////////////////////////////

namespace WpfHelper.Test.ViewModel.Workspaces
{
    /// <summary>
    /// Describes the "WpfHelper.Workspaces.WorkspaceViewModel" class.
    /// </summary>
    [TestClass]
    public class WorkspaceViewModelTest
    {
        ////////////////////////////////////////
        #region Constructor (Auto-generated)

        public WorkspaceViewModelTest()
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
            TestWorkspaceViewModel _viewModel = new TestWorkspaceViewModel();

            Assert.AreEqual("New Workspace", _viewModel.Header);
        }

        [TestMethod]
        public void Constructor_EmptyDefaults_ViewModelIsActive()
        {
            TestWorkspaceViewModel _viewModel = new TestWorkspaceViewModel();

            Assert.IsTrue(_viewModel.IsActive);
        }

        #endregion

        ////////////////////////////////////////
        #region Child Classes (Used in Testing)

        class TestWorkspaceViewModel : WorkspaceViewModel
        {
            // empty constructor so class inherits values from base constructor
            public TestWorkspaceViewModel() { }
        }

        #endregion
    }
}

///////////////////////////////////////
#region Namespace Directives

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows; // via the "PresentationFramework.dll" assembly
using WpfHelper.Initialization;
using WpfHelper.ViewModel.Windows;

#endregion
///////////////////////////////////////

// Additional Project References required for use of Window objects within this class (just as in "WpfHelper.ViewModel.Windows.WindowInitializer"):
// (1) "PresentationFramework.dll" for making WPF Window objects accessible in "System.Windows".
// (2) "PresentationCore.dll" for generating UIElements within the window.
// (3) "System.Xaml.dll" to expose the "System.Windows.Markup.IQueryAmbient" interface.
// (4) "WindowsBase.dll" to expose the "System.Windows.DependencyObject" class.

namespace WpfHelper.Test.Initialization
{
    [TestClass]
    public class WindowInitializer_spec
    {
        ////////////////////////////////////////
        #region Unit Tests (Methods)

        [TestMethod]
        public void Close_WindowCloses_ViewModelIsInActive()
        {
            TestWindow _window = new TestWindow();
            TestWindowViewModel _viewModel = new TestWindowViewModel();
            WindowInitializer _initializer = new WindowInitializer(_window, _viewModel);

            _initializer.Close();

            Assert.IsFalse(_window.IsActive);
        }

        [TestMethod]
        public void Show_WindowOpens_ViewModelIsActive()
        {
            TestWindow _window = new TestWindow();
            TestWindowViewModel _viewModel = new TestWindowViewModel();
            WindowInitializer _initializer = new WindowInitializer(_window, _viewModel);

            _initializer.Show();

            Assert.IsTrue(_window.IsActive);
        }

        [TestMethod]
        public void ViewModelIsActiveProperty_False_WindowCloses()
        {
            TestWindow _window = new TestWindow();
            TestWindowViewModel _viewModel = new TestWindowViewModel();
            WindowInitializer _initializer = new WindowInitializer(_window, _viewModel);

            _viewModel.IsActive = false;

            Assert.IsFalse(_window.IsActive);
        }

        #endregion

        ////////////////////////////////////////
        #region Child Classes (Used in Testing)

        class TestWindow : Window
        {
            public TestWindow() { }
        }

        class TestWindowViewModel : WindowViewModel
        {
            public TestWindowViewModel() : base("Test Window", false) { }
        }

        #endregion
    }
}

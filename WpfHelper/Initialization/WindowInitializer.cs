///////////////////////////////////////
#region Namespace Directives

using System;
using System.Windows; // via the "PresentationFramework.dll" assembly
using WpfHelper.ViewModel.Windows;

#endregion
///////////////////////////////////////

// Additional Project References required for use of Window objects within this class:
// (1) "PresentationFramework.dll" for making WPF Window objects accessible in "System.Windows".
// (2) "PresentationCore.dll" for generating UIElements within the window.
// (3) "System.Xaml.dll" to expose the "System.Windows.Markup.IQueryAmbient" interface.
// (4) "WindowsBase.dll" to expose the "System.Windows.DependencyObject" class.

namespace WpfHelper.Initialization
{
    /// <summary>
    /// Aid for implementing MVVM architecture in WPF applications. 
    /// Maps a window ViewModel object to a WPF Window markup file and assigns event handlers to mimic WinForms functionality.
    /// </summary>
    /// <remarks>
    /// To instantiate application windows with this class: 
    /// (1) Remove the "MainWindow.xaml" StartupUri reference from "App.xaml" in the auto-generated WPF Application project files.
    /// (2) Create a constructor method within "App.xaml.cs". You can find this class by clicking the caret next to "App.xaml" in Solution Explorer and adding a public "App()" within the file.
    /// (3) Create an instance of this object within the constructor (or one of the supporting methods running within it) to map Window and ViewModel objects to one another.
    /// (4) Call the "Show()" method on this object to display the window and relay control of the Window to its assigned ViewModel. This will display the first window seen by the user.
    /// (5) Repeat steps (3) and (4) within any other part of the application that you want to transition to new windows from.
    /// </remarks>
    public class WindowInitializer
    {
        ////////////////////////////////////////
        #region  Generic Fields

        private Window _window;
        private IWindowViewModel _windowViewModel;

        #endregion

        ////////////////////////////////////////
        #region  Constructor(s)

        /// <summary>
        /// Creates a WPF Window object with an attached ViewModel.
        /// </summary>
        /// <param name="window">The XAML markup object the viewmodel is to be mapped to.</param>
        /// <param name="windowViewModel">The object assigned to the window as a ViewModel.</param>
        public WindowInitializer(Window window, IWindowViewModel windowViewModel) : this(window, windowViewModel, true) { }

        /// <summary>
        /// Creates a WPF Window object with an attached ViewModel. Offers the option to enable/disable event handlers.
        /// </summary>
        /// <param name="window">The XAML markup object the viewmodel is to be mapped to.</param>
        /// <param name="windowViewModel">The object assigned to the window as a ViewModel.</param>
        /// <param name="hasEventHandlers">Indicates whether or not the ViewModel has control over window state.</param>
        public WindowInitializer(Window window, IWindowViewModel windowViewModel, bool hasEventHandlers)
        {
            _window = window;
            _windowViewModel = windowViewModel;

            if (hasEventHandlers)
            {
                _windowViewModel.PropertyChanged += windowViewModel_PropertyChanged;
            }

            window.DataContext = _windowViewModel;
        }

        #endregion

        ////////////////////////////////////////
        #region  Methods

        /// <summary>
        /// Closes the Window by marking it as InActive, removing control of the Window from the attached ViewModel.
        /// </summary>
        public void Close()
        {
            _windowViewModel.IsActive = false;
        }

        /// <summary>
        /// Shows the window, effectively passing control of the window to the attached ViewModel.
        /// </summary>
        public void Show()
        {
            _window.Show();
        }

        #endregion

        ////////////////////////////////////////
        #region  Event Handlers

        /// <summary>
        /// Event handler fired during property changes to the ViewModel. Manages actions related to window state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void windowViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            IWindowViewModel windowVm = sender as IWindowViewModel;

            if (windowVm.IsActive == false)
            {
                _window.Close();
            }
        }

        #endregion
    }
}

///////////////////////////////////////
#region Namespace Directives

using System;
using WpfHelper.PropertyChanged;

#endregion
///////////////////////////////////////

namespace WpfHelper.ViewModel
{
    /// <summary>
    /// Creates a logical representation of a basic ViewModel mapped to a "System.Windows.UIElement" object.
    /// </summary>
    public abstract class ViewModelBase : propertyChangedNotificationHandling, IViewModel
    {
        ////////////////////////////////////////
        #region Constants

        const string _defaultHeader = "App UIElement";

        #endregion

        ////////////////////////////////////////
        #region  Generic Fields

        private string _header;

        #endregion

        ////////////////////////////////////////
        #region Properties

        /// <summary>
        /// Indicates a title for the "System.Windows.UIElement" object this ViewModel is mapped to.
        /// </summary>
        public string Header
        {
            get
            {
                return _header;
            }
            set
            {
                _header = value;
                OnPropertyChanged("Header");
            }
        }

        #endregion

        ////////////////////////////////////////
        #region Constructor(s)

        /// <summary>
        /// Creates a new back-end for a basic WPF UIElement.
        /// </summary>
        public ViewModelBase() : this(_defaultHeader) { }

        /// <summary>
        /// Creates a new back-end for a basic WPF UIElement.
        /// </summary>
        public ViewModelBase(string header)
        {
            Header = header;
        }

        #endregion
    }
}

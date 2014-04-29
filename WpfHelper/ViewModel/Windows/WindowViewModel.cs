///////////////////////////////////////
#region Namespace Directives

using System;
using System.ComponentModel;
using WpfHelper.ViewModel;

#endregion
///////////////////////////////////////

namespace WpfHelper.ViewModel.Windows
{
    /// <summary>
    /// Creates a logical representation of a basic window ViewModel.
    /// </summary>
    public abstract class WindowViewModel : ViewModelBase, IWindowViewModel
    {
        ////////////////////////////////////////
        #region Constants

        const string _defaultHeader = "App Window";

        #endregion

        ////////////////////////////////////////
        #region  Generic Fields

        private bool _isActive;
        private bool _isParent;

        #endregion

        ////////////////////////////////////////
        #region Members

        /// <summary>
        /// Indicates whether or not this window is Active (i.e. open/closed).
        /// </summary>
        public bool IsActive
        {
            get
            {
                return _isActive;
            }
            set
            {
                _isActive = value;
                OnPropertyChanged("IsActive");
            }
        }

        /// <summary>
        /// Indicates whether or not this window mimics the role of a parent window in a Winforms MDI application.
        /// </summary>
        public bool IsParent
        {
            get
            {
                return _isParent;
            }
            set
            {
                _isParent = value;
                OnPropertyChanged("IsParent");
            }
        }

        #endregion

        ////////////////////////////////////////
        #region Constructor(s)

        /// <summary>
        /// Creates a new back-end for a basic WPF window.
        /// </summary>
        public WindowViewModel() : this(_defaultHeader, false) { }

        /// <summary>
        /// Creates a new back-end for a basic WPF window.
        /// </summary>
        public WindowViewModel(string header) : this(header, false) { }

        /// <summary>
        /// Creates a new back-end for a basic WPF window.
        /// </summary>
        public WindowViewModel(string header, bool isParent) : base(header)
        {
            IsActive = true;
            IsParent = isParent;
        }

        #endregion
    }
}

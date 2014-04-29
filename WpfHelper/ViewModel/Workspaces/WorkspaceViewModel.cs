///////////////////////////////////////
#region Namespace Directives

using System;
using WpfHelper.ViewModel;

#endregion
//////////////////////////////////////

namespace WpfHelper.ViewModel.Workspaces
{
    /// <summary>
    /// Creates a logical representation of a basic removable workspace within a WPF application.
    /// </summary>
    public abstract class WorkspaceViewModel : ViewModelBase, IWorkspaceViewModel
    {
        ////////////////////////////////////////
        #region Constants

        const string _defaultHeader = "New Workspace";

        #endregion

        ////////////////////////////////////////
        #region  Generic Fields

        private bool _isActive;

        #endregion

        ////////////////////////////////////////
        #region Members

        /// <summary>
        /// Indicates whether or not this workspace is Active (i.e. open/closed).
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

        #endregion

        ////////////////////////////////////////
        #region Constructor(s)

        /// <summary>
        /// Creates a new back-end for a removable workspace within a WPF application.
        /// </summary>
        public WorkspaceViewModel() : this(_defaultHeader) { }

        /// <summary>
        /// Creates a new back-end for a removable workspace within a WPF application.
        /// </summary>
        public WorkspaceViewModel(string header)
            : base(header)
        {
            IsActive = true;
        }

        #endregion
    }
}

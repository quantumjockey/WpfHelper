///////////////////////////////////////
#region Namespace Directives

using WpfHelper.ViewModel.Controls;

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
        #region Actions

        /// <summary>
        /// Exposes an action that allows the user to deactivate this workspace.
        /// </summary>
        public CommandDrivenControlViewModel DeactivateWorkspace
        {
            get;
            private set;
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
            InitializeClosableWorkspaceActions();
        }

        #endregion

        ////////////////////////////////////////
        #region Supporting Methods

        private void InitializeClosableWorkspaceActions()
        {
            DeactivateWorkspace = new CommandDrivenControlViewModel((x) => MakeWorkspaceInactive(), "Close", "Close this workspace.");
        }

        private void MakeWorkspaceInactive()
        {
            IsActive = false;
        }

        #endregion
    }
}

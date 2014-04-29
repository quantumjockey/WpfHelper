///////////////////////////////////////
#region Namespace Directives

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

#endregion
///////////////////////////////////////

namespace WpfHelper.ViewModel.Workspaces
{
    /// <summary>
    /// An extension of "System.Collections.ObjectModel.ObservableCollection" that facilitates the storage and 
    /// automatic removal of workspaces after they are closed by the user.
    /// </summary>
    public class WorkspaceViewModelCollection : ObservableCollection<IWorkspaceViewModel>
    {
        ////////////////////////////////////////
        #region  IList Methods

        public new void Add(IWorkspaceViewModel workspace)
        {
            workspace.PropertyChanged += workspace_PropertyChanged;
            base.Add(workspace);
        }

        #endregion

        ////////////////////////////////////////
        #region  Event Handling

        void workspace_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            IWorkspaceViewModel workspaceVm = sender as IWorkspaceViewModel;

            if (workspaceVm.IsActive == false)
            {
                base.Remove(workspaceVm);
            }
        }

        #endregion
    }
}

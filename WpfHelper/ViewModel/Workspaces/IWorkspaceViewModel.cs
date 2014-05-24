///////////////////////////////////////
#region Namespace Directives

using System.ComponentModel;

#endregion
///////////////////////////////////////

namespace WpfHelper.ViewModel.Workspaces
{
    public interface IWorkspaceViewModel : INotifyPropertyChanged
    {
        // Property Signatures
        bool IsActive { get; set; }
    }
}

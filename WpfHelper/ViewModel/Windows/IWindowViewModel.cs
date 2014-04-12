///////////////////////////////////////
#region Namespace Directives

using System;
using System.ComponentModel;

#endregion
///////////////////////////////////////

namespace WpfHelper.ViewModel.Windows
{
    /// <summary>
    /// Template for a class mapped to a WPF Window object as a ViewModel.
    /// </summary>
    public interface IWindowViewModel
    {
        // Property Signatures
        bool IsActive { get; set; }
        bool IsParent { get; set; }

        // Event Signatures
        event PropertyChangedEventHandler PropertyChanged;
    }
}

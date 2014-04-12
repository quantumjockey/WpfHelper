///////////////////////////////////////
#region Namespace Directives

using System;

#endregion
///////////////////////////////////////

namespace WpfHelper.ViewModel
{
    /// <summary>
    /// Template for a class mapped to a WPF UIElement (System.Windows.UIElement) as a ViewModel.
    /// </summary>
    public interface IViewModel
    {
        // Property Signatures
        string Header { get; set; }
    }
}

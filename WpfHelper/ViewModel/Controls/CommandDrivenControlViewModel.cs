///////////////////////////////////////
#region Namespace Directives

using System;
using System.Windows.Input;
using WpfHelper.Command;

#endregion
///////////////////////////////////////

namespace WpfHelper.ViewModel.Controls
{
    /// <summary>
    /// Implements an object container/back-end for all controls that have an associated "Command" property (HyperLinks, Buttons, MenuItems, etc).
    /// </summary>
    /// <remarks>
    /// Reference: "WPF Apps With the Model-View-ViewModel Design Pattern" 
    ///            on <http://msdn.microsoft.com/en-us/magazine/dd419663.aspx>
    ///            Originally accessed on 4/14/2013.
    ///            Reviewed on 4/12/2014.
    ///            Some code and comments are partially excerpted from the article and its source, but modified 
    ///            according to the developer's preference and understanding of the MVVM architectural pattern.
    /// </remarks>
    public class CommandDrivenControlViewModel
    {
        ////////////////////////////////////////
        #region Constants

        const string _tooltipInitialized = "Click to perform labeled action.";
        const string _tooltipNotInitialized = "Not initialized. Cannot perform labeled action.";

        #endregion

        ////////////////////////////////////////
        #region Properties

        /// <summary>
        /// Implements a potential action (templated against the view in resource files).
        /// </summary>
        public ICommand Action
        {
            get;
            private set;
        }

        /// <summary>
        /// Exposes a name for this Action.
        /// </summary>
        public string Name
        {
            get;
            private set;
        }

        /// <summary>
        /// Stores a tooltip for this action.
        /// </summary>
        public string ToolTip
        {
            get;
            private set;
        }

        #endregion

        ////////////////////////////////////////
        #region Constructors

        /// <summary>
        /// Creates an Command-driven control (back-end) with basic characteristics.
        /// </summary>
        /// <param name="action">The action to be executed via ICommand member.</param>
        /// <param name="name">The name of this action.</param>
        public CommandDrivenControlViewModel(Action<object> action, string name) : this(action, null, name, (action != null) ? _tooltipInitialized : _tooltipNotInitialized) { }

        /// <summary>
        /// Creates an Command-driven control (back-end) with basic characteristics.
        /// </summary>
        /// <param name="action">The action to be executed via ICommand member.</param>
        /// <param name="name">The name of this action.</param>
        /// <param name="toolTip">The mouse-over text associated with the view this action is mapped to.</param>
        public CommandDrivenControlViewModel(Action<object> action, string name, string toolTip) : this(action, null, name, toolTip) { }

        /// <summary>
        /// Creates an Command-driven control (back-end) with basic characteristics.
        /// </summary>
        /// <param name="action">The action to be executed via ICommand member.</param>
        /// <param name="canPerform">Conditions for the action to be performed.</param>
        /// <param name="name">The name of this action.</param>
        /// <param name="toolTip">The mouse-over text associated with the view this action is mapped to.</param>
        public CommandDrivenControlViewModel(Action<object> action, Predicate<object> canPerform, string name, string toolTip)
        {
            this.Action = new CommandRelay(action, canPerform);
            this.Name = name;
            this.ToolTip = toolTip;
        }

        #endregion
    }
}

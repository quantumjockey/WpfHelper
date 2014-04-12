///////////////////////////////////////
#region Namespace Directives

using System;
using System.Windows.Input;
using System.Runtime.CompilerServices;

#endregion
////////////////////////////////////////

// Debugging Attributes
[assembly: InternalsVisibleTo("WpfHelper.Test")]

namespace WpfHelper.Command
{
    /// <summary>
    /// Creates a Command via implementation of the "System.Windows.Input.ICommand" interface.
    /// </summary>
    internal class CommandRelay : ICommand
    {
        ////////////////////////////////////////
        #region Fields

        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;

        #endregion

        ////////////////////////////////////////
        #region Constructors

        /// <summary>
        /// Creates a new command.
        /// </summary>
        /// <param name="execute">The action delegate wrapped within the command.</param>
        public CommandRelay(Action<object> execute) : this(execute, null) { }

        /// <summary>
        /// Creates a new command.
        /// </summary>
        /// <param name="execute">The action delegate wrapped within the command.</param>
        /// <param name="canExecute">Determines whether or not the delegate containing the command's executable action is under condition to execute.</param>
        public CommandRelay(Action<object> execute, Predicate<object> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        #endregion

        ////////////////////////////////////////
        #region Methods

        /// <summary>
        /// Determines whether or not this command is under condition to execute.
        /// </summary>
        /// <param name="parameter">A Predicate delegate that processes condition for execution.</param>
        /// <returns>Whether or not the command can execute.</returns>
        public bool CanExecute(object parameter)
        {
            bool isValid = false;

            if (_execute != null)
            {
                isValid = (_canExecute == null) ? true : _canExecute(parameter);
            }
            else
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Induces execution of the Action delegate wrapped by this command.
        /// </summary>
        /// <param name="parameter">The Action delegate to be executed.</param>
        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        #endregion

        ////////////////////////////////////////
        #region Event Handlers

        /// <summary>
        /// Event handler for changes in the condition for execution of the Action delegate.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        #endregion
    }
}

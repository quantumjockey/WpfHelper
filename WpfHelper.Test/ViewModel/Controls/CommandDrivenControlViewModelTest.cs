///////////////////////////////////////
#region Namespace Directives

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WpfHelper.ViewModel.Controls;

#endregion
///////////////////////////////////////

namespace WpfHelper.Test.ViewModel.Controls
{
    [TestClass]
    public class CommandDrivenControlViewModelTest
    {
        ////////////////////////////////////////
        #region Unit Tests (Methods)

        [TestMethod]
        public void Constructor_ActionIsNotNull_CommandExecutes()
        {
            CommandDrivenControlViewModel _viewModel = new CommandDrivenControlViewModel((x) => SomeMethodThatDoesSomething(), "Action!");

            Assert.IsTrue(_viewModel.Action.CanExecute(new object()));
        }

        [TestMethod]
        public void Constructor_ActionIsNull_CommandDoesNotExecute()
        {
            CommandDrivenControlViewModel _viewModel = new CommandDrivenControlViewModel(null, "Action!");

            Assert.IsFalse(_viewModel.Action.CanExecute(new object()));
        }

        [TestMethod]
        public void Constructor_PredicateConditionsAreMet_CommandExecutes()
        {
            int num = 6;
            CommandDrivenControlViewModel _viewModel = new CommandDrivenControlViewModel((x) => SomeMethodThatDoesSomething(), (y) => (int)y > 5, "Action!", "Click here!");

            Assert.IsTrue(_viewModel.Action.CanExecute(num));
        }

        [TestMethod]
        public void Constructor_PredicateConditionsAreNotMet_CommandDoesNotExecute()
        {
            int num = 4;
            CommandDrivenControlViewModel _viewModel = new CommandDrivenControlViewModel((x) => SomeMethodThatDoesSomething(), (y) => (int)y > 5, "Action!", "Click here!");

            Assert.IsFalse(_viewModel.Action.CanExecute(num));
        }

        [TestMethod]
        public void Constructor_PredicateIsNull_CommandExecutes()
        {
            CommandDrivenControlViewModel _viewModel = new CommandDrivenControlViewModel((x) => SomeMethodThatDoesSomething(), null, "Action!", "Click here!");

            Assert.IsTrue(_viewModel.Action.CanExecute(new object()));
        }

        [TestMethod]
        public void ConstructorWithoutToolTip_ActionIsNotNull_HeaderIsNotEmptyString()
        {
            CommandDrivenControlViewModel _viewModel = new CommandDrivenControlViewModel((x) => SomeMethodThatDoesSomething(), "Action!");

            Assert.AreNotEqual(String.Empty, _viewModel.ToolTip);
        }

        [TestMethod]
        public void ConstructorWithoutToolTip_ActionIsNotNull_ToolTipReadsInitializedMessage()
        {
            CommandDrivenControlViewModel _viewModel = new CommandDrivenControlViewModel((x) => SomeMethodThatDoesSomething(), "Action!");

            Assert.AreEqual("Click to perform labeled action.", _viewModel.ToolTip);
        }

        [TestMethod]
        public void ConstructorWithoutToolTip_ActionIsNull_ToolTipReadsNotInitializedMessage()
        {
            CommandDrivenControlViewModel _viewModel = new CommandDrivenControlViewModel(null, "Action!");

            Assert.AreEqual("Not initialized. Cannot perform labeled action.", _viewModel.ToolTip);
        }

        #endregion

        ////////////////////////////////////////
        #region Supporting Methods (Used in Testing)

        private void SomeMethodThatDoesSomething()
        {
            // placeholder - do nothing
        }

        #endregion
    }
}

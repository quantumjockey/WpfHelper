///////////////////////////////////////
#region Namespace Directives

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WpfHelper.Command;

#endregion
///////////////////////////////////////

namespace WpfHelper.Test.Command
{
    /// <summary>
    /// Unit tests addressing functionality within the "WpfHelper.Command.CommandRelay" class.
    /// </summary>
    [TestClass]
    public class CommandRelayTest
    {
        ////////////////////////////////////////
        #region Unit Tests (Methods)

        [TestMethod]
        public void Constructor_ActionIsNotNull_CommandExecutes()
        {
            CommandRelay relay = new CommandRelay((x) => SomeMethodThatDoesSomething());

            Assert.IsTrue(relay.CanExecute(new object()));
        }

        [TestMethod]
        public void Constructor_ActionIsNull_CommandDoesNotExecute()
        {
            CommandRelay relay = new CommandRelay(null);

            Assert.IsFalse(relay.CanExecute(new object()));
        }

        [TestMethod]
        public void Constructor_PredicateConditionsAreMet_CommandExecutes()
        {
            int num = 6;
            CommandRelay relay = new CommandRelay((x) => SomeMethodThatDoesSomething(), (y) => (int)y > 5);

            Assert.IsTrue(relay.CanExecute(num));
        }

        [TestMethod]
        public void Constructor_PredicateConditionsAreNotMet_CommandDoesNotExecute()
        {
            int num = 4;
            CommandRelay relay = new CommandRelay((x) => SomeMethodThatDoesSomething(), (y) => (int)y > 5);

            Assert.IsFalse(relay.CanExecute(num));
        }

        [TestMethod]
        public void Constructor_PredicateIsNull_CommandExecutes()
        {
            CommandRelay relay = new CommandRelay((x) => SomeMethodThatDoesSomething(), null);

            Assert.IsTrue(relay.CanExecute(new object()));
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

using System;

namespace FrameWork
{
    class CreateCommandCheckLinkPresentByName : CommandCreator
    {
        public CreateCommandCheckLinkPresentByName(CommandCreator Successor)
        {
            this.Successor = Successor;
        }

        public override ICommand CreateCommand(string commandString, Tester tester)
        {
            ICommand command = null;
            if (commandString.Contains(Resources.CheckLinkPresentByName))
            {
                command = new CheckLinkPresentByNameCommand(tester);
            }
            else
            {
                command = Successor.CreateCommand(commandString, tester);
            }
            return command;
        }

        public override void ParseCommand(string command)
        {
            throw new NotImplementedException();
        }
    }
}

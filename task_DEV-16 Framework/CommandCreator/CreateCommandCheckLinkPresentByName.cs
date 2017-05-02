using System;

namespace FrameWork
{
    class CreateCommandCheckLinkPresentByName : CommandCreator
    {
        private string name;
        public CreateCommandCheckLinkPresentByName(CommandCreator Successor)
        {
            this.Successor = Successor;
        }

        public override ICommand CreateCommand(string commandString, Tester tester)
        {
            ICommand command = null;
            if (commandString.Contains(Resources.CheckLinkPresentByName))
            {
                ParseCommand(commandString);
                command = new CheckLinkPresentByNameCommand(tester,name);
            }
            else
            {
                command = Successor.CreateCommand(commandString, tester);
            }
            return command;
        }

        public override void ParseCommand(string command)
        {
            string[] splitString = command.Split(separators, 2);
            name = splitString[1].Replace("\"", "");
        }
    }
}

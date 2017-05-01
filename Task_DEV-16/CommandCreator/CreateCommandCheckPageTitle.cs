using System;

namespace FrameWork
{
    class CreateCommandCheckPageTitle : CommandCreator
    {
        private string title;
        public CreateCommandCheckPageTitle(CommandCreator Successor)
        {
            this.Successor = Successor;
        }

        public override ICommand CreateCommand(string commandString, Tester tester)
        {
            ICommand command = null;
            if (commandString.Contains(Resources.checkPageTitle))
            {
                ParseCommand(commandString);
                command = new CheckPageTitleCommand(tester,title);
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
            title = splitString[1].Replace("\"", "");
        }
    }
}

using System;

namespace FrameWork
{
    class CreateCommandCheckPageContains : CommandCreator
    {
        private string content;
        public CreateCommandCheckPageContains(CommandCreator Successor)
        {
            this.Successor = Successor;
        }

        public override ICommand CreateCommand(string commandString, Tester tester)
        {
            ICommand command = null;
            if (commandString.Contains(Resources.checkPageContains))
            {
                ParseCommand(commandString);
                command = new CheckPageContainsCommand(tester,content);
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
            content = splitString[1].Replace("\"","");
        }
    }
}

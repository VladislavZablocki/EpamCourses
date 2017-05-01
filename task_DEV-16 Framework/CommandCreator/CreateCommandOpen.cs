using System;

namespace FrameWork
{
    class CreateCommandOpen : CommandCreator
    {
        private string url;
        private double timeout;

        public CreateCommandOpen(CommandCreator Successor)
        {
            this.Successor = Successor;
        }

        public override ICommand CreateCommand(string commandString, Tester tester)
        {
            ICommand command = null;
            if (commandString.Contains(Resources.Open))
            {
                ParseCommand(commandString);
                command = new OpenCommand(tester, url, timeout);
            }
            else
            {
                command = Successor.CreateCommand(commandString, tester);
            }
            return command;
        }

        public override void ParseCommand(string command)
        {
            string[] splitString = command.Split(separators, 3);
            timeout = double.Parse(splitString[2].Replace("\"", ""));
            url = splitString[1].Replace("\"", "");
        }
    }
}

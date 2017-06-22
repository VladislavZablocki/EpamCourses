using System;

namespace FrameWork
{
    class CreateCommandCheckLinkByhref : CommandCreator
    {
        private string href;
        public CreateCommandCheckLinkByhref(CommandCreator Successor)
        {
            this.Successor = Successor;
        }

        public override ICommand CreateCommand(string commandString,Tester tester)
        {
            ICommand command = null;
            if (commandString.Contains(Resources.CheckLinkPresentByHref))
            {
                ParseCommand(commandString);
                command = new СheckLinkPresentByHrefCommand(tester,href);
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
            href = splitString[1].Replace("\"", "");
        }
    }
}

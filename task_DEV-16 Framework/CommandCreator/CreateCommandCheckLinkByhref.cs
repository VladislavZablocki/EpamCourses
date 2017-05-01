using System;

namespace FrameWork
{
    class CreateCommandCheckLinkByhref : CommandCreator
    {
        public CreateCommandCheckLinkByhref(CommandCreator Successor)
        {
            this.Successor = Successor;
        }

        public override ICommand CreateCommand(string commandString,Tester tester)
        {
            ICommand command = null;
            if (commandString.Contains(Resources.CheckLinkPresentByHref))
            {
                command = new СheckLinkPresentByHrefCommand(tester);
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

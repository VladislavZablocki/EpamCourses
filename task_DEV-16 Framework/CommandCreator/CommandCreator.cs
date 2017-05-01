namespace FrameWork
{
    public abstract class CommandCreator
    {
        public char[] separators = { ' ' };
        public CommandCreator Successor { get; set; }
        public abstract ICommand CreateCommand(string commandString, Tester tester);
        public abstract void ParseCommand(string command);
    }
}

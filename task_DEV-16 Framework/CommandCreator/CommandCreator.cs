namespace FrameWork
{
    /// <summary>
    /// Abstract class which contains reference to next command creator, method which check whick
    /// command this is and command parser
    /// </summary>
    public abstract class CommandCreator
    {
        public char[] separators = { ' ' };
        public CommandCreator Successor { get; set; }
        public abstract ICommand CreateCommand(string commandString, Tester tester);
        public abstract void ParseCommand(string command);
    }
}

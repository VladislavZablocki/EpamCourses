namespace FrameWork
{
    class CheckPageContainsCommand : ICommand 
    {
        private Tester tester;
        private string content;
        public CheckPageContainsCommand(Tester tester,string content)
        {
            this.tester = tester;
            this.content = content;
        }
        public void Execute()
        {
            tester.CheckPageContains(content);
        }
    }
}

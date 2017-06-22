namespace FrameWork
{
    class CheckLinkPresentByNameCommand : ICommand
    {
        private Tester tester;
        private string name;
        public CheckLinkPresentByNameCommand(Tester tester,string name)
        {
            this.name = name;
            this.tester = tester;
        }
        public void Execute()
        {
            tester.CheckLinkPresentByName(name);
        }
    }
}

namespace FrameWork
{
    class CheckLinkPresentByNameCommand : ICommand
    {
        Tester tester;
        public CheckLinkPresentByNameCommand(Tester tester)
        {
            this.tester = tester;
        }
        public void Execute()
        {
            tester.CheckLinkPresentByName();
        }
    }
}

namespace FrameWork
{
    class СheckLinkPresentByHrefCommand : ICommand
    {
        Tester tester;
        public СheckLinkPresentByHrefCommand(Tester tester)
        {
            this.tester = tester;
        }
        public void Execute()
        {
            tester.CheckLinkByHref();
        }
    }
}

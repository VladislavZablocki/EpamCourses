namespace FrameWork
{
    class СheckLinkPresentByHrefCommand : ICommand
    {
        private Tester tester;
        private string href;
        public СheckLinkPresentByHrefCommand(Tester tester,string href)
        {
            this.href = href;
            this.tester = tester;
        }
        public void Execute()
        {
            tester.CheckLinkByHref(href);
        }
    }
}

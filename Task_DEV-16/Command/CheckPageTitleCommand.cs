namespace FrameWork
{
    class CheckPageTitleCommand : ICommand
    {
        private  Tester tester;
        private string title;
        public CheckPageTitleCommand(Tester tester,string title)
        {
            this.tester = tester;
            this.title = title;
        }
        public void Execute()
        {
            tester.CheckPageTitle(title);
        }
    }
}

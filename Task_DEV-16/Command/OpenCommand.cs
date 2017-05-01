namespace FrameWork
{
    class OpenCommand : ICommand
    {
        private Tester tester;
        private string url;
        private double timeout;
        public OpenCommand(Tester tester, string url, double timeout)
        {
            this.tester = tester;
            this.url = url;
            this.timeout = timeout;
        }
        public void Execute()
        {
            tester.Open(url, timeout);
        }
    }
}

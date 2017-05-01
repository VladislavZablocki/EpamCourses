using System;

namespace FrameWork
{
    class Program
    {
        static void Main(string[] args)
        {

                string path = @"E:\c#\FrameWork\test.txt";
                CommandCreator commandForTesting = new CreateCommandOpen(
                    new CreateCommandCheckPageTitle(
                        new CreateCommandCheckPageContains(
                            new CreateCommandCheckLinkPresentByName(
                                new CreateCommandCheckLinkByhref(null)))));
                Tester tester = new Tester(path, commandForTesting);
                tester.ReadCommand();
        }
    }
}

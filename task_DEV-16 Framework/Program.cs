using System;

namespace FrameWork
{
    /// <summary>
    /// Entry point of test framework, which contains path to file with command and statistics of test
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
                string pathWithCommand = @"E:\c#\FrameWork\test.txt";
                string outputPath = @"E:\c#\FrameWork\statistics.txt";
                CommandCreator commandForTesting = new CreateCommandOpen(
                    new CreateCommandCheckPageTitle(
                        new CreateCommandCheckPageContains(
                            new CreateCommandCheckLinkPresentByName(
                                new CreateCommandCheckLinkByhref(null)))));
                Tester tester = new Tester(pathWithCommand, outputPath, commandForTesting);
                tester.ReadCommand();
        }
    }
}

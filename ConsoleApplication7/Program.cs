namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            var directory = args[0];
            var filename = args[1];
            var searchParam = args[2];

            var crawler = new Crawler();
            var excel = new Excel();

            var matches = crawler.DirSearch(directory, filename, searchParam);

            excel.SaveToExcel(matches, searchParam);
        }
    }
}

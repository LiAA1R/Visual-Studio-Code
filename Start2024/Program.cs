internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Podaj nazwę  folderów: ");
        string ?nazwaFolderu = Console.ReadLine();

        Console.WriteLine("No dobra podałeś dane, zobaczysz co się stanie");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Folder" + nazwaFolderu + i);
            Directory.CreateDirectory("foldery\\"+nazwaFolderu + i);
        }
    }
}
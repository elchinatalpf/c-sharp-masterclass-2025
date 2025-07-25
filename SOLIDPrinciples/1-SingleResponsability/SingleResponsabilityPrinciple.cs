using SOLIDPrinciples.SingleResponsability.DataAccess;

namespace SOLIDPrinciples.SingleResponsability;



public class SingleResponsabilityPrinciple
{
    public static void Run()
    {
        var names = new Names();
        var path = new NamesFilePathBuilder().BuildFilePath();
        var stringsTextualRepository = new StringsTextualRepository();
        if (File.Exists(path))
        {
            Console.WriteLine("Names file already exists. Loading names.");
            var stringsFromFile = stringsTextualRepository.Read(path);
            names.AddNames(stringsFromFile);
        }
        else
        {
            Console.WriteLine("Name file does not yet exist.");
            names.AddName("John");
            names.AddName("not a valid name");
            names.AddName("Claire");
            names.AddName("123 definitely not a valid name");

            Console.WriteLine("Saving names to a file.");
            stringsTextualRepository.Write(path, names.All);
        }
        Console.WriteLine(new NamesFormatter().Format(names.All));
        Console.ReadKey();

    }
}


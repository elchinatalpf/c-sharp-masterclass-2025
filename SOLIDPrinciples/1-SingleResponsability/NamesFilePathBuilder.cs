namespace SOLIDPrinciples.SingleResponsability;

class NamesFilePathBuilder
{
    public string BuildFilePath()
    {
        var fileName = "names.txt";
        var currentDirectory = Directory.GetCurrentDirectory();
        return Path.Combine(currentDirectory, fileName);
    }
}


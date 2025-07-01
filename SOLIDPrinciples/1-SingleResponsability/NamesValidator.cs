namespace SOLIDPrinciples.SingleResponsability;

class NamesValidator
{
    public bool isValid(string name)
    {
        return name.Length >= 2 && name.Length < 25 && char.IsUpper(name[0]) && name.All(char.IsLetter);
    }
}


namespace SOLIDPrinciples.SingleResponsability;

class NamesFormatter
{
    public string Format(List<string> names)
    {
        return string.Join(Environment.NewLine, names);
    }
}


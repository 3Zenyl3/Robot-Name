public class Robot
{
    private static Random random = new Random();
    private string name;
    private static HashSet<string> usedNames = new HashSet<string>();
    public string Name
    {
        get
        {
            if(name == null)
            {
                name = GenerateUniqueName();
            }
            return name;
            
        }
        set
        {
            name = value;
        }
    }

    public void Reset()
    {
       Name = null;
    }
    private string GenerateUniqueName()
{
    string res;
    do
    {
        char first = (char)('A' + random.Next(0, 26));
        char second = (char)('A' + random.Next(0, 26));
        char th = (char)('0' + random.Next(0, 10));
        char four = (char)('0' + random.Next(0, 10));
        char five = (char)('0' + random.Next(0, 10));
        res = new string(new char[] { first, second, th, four, five });

        lock (usedNames)
        {
            if (usedNames.Add(res))
                break;
        }
    } while (true);

    return res;
}
}

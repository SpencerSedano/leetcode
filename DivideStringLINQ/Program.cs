using Dumpify;

namespace DivideStringLINQ;

class Program
{
    static void Main(string[] args)
    {
        string sOne = "abcdefghi";
        int kOne = 3;
        char fillOne = 'x';

        string sTwo = "abcdefghij";
        int kTwo = 3;
        char fillTwo = 'x';
        
        DivideString(sOne, kOne, fillOne).Dump();
        DivideString(sTwo, kTwo, fillTwo).Dump();
        
        string[] DivideString(string s, int k, char fill)
        {
            int totalGroups = (int)Math.Ceiling((double)s.Length / k);

            return Enumerable.Range(0, totalGroups)
                .Select(i =>
                {
                    var part = s.Skip(i * k).Take(k).ToArray();
                    return new string(part).PadRight(k, fill);
                })
                .ToArray();
        }
    }
}
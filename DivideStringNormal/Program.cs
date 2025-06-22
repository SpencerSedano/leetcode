using Dumpify;

namespace DivideStringNormal;

class Program
{
    /*
     https://leetcode.com/problems/divide-a-string-into-groups-of-size-k/?envType=daily-question&envId=2025-06-22
     
     2138. Divide a String Into Groups of Size k
     
     A string s can be partitioned into groups of size k using the following procedure:
       
       The first group consists of the first k characters of the string, the second group consists of the next k characters of the string, and so on. Each element can be a part of exactly one group.
       For the last group, if the string does not have k characters remaining, a character fill is used to complete the group.
       Note that the partition is done so that after removing the fill character from the last group (if it exists) and concatenating all the groups in order, the resultant string should be s.
       
       Given the string s, the size of each group k and the character fill, return a string array denoting the composition of every group s has been divided into, using the above procedure.
     */
    
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
            var myList = new List<string>();
            
            int remainder = s.Length % k;
            int result = (s.Length - remainder) / k;
            
            int counter = 0;
            
            for (int i = 0; i < s.Length; i += k)
            {
                if (counter < result)
                {
                    if (s.Substring(i, k).Length % k == 0)
                    {
                        myList.Add(s.Substring(i, k));
                    }
                    counter++;
                }
                else
                {
                    string newString = s.Substring(i, remainder);
                    int howMany = k - remainder;
                    for (int j = 0; j < howMany; j++)
                    {
                        newString += fill;
                    }
                    myList.Add(newString);
                }
            
            }
            return myList.ToArray();
        }

    }
}
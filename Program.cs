using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, char> Decoder = new Dictionary<char, char>()
            {
                {'?' , 'A'},
                {'~' , 'B'},
                {'\'' , 'C'},
                {'H' , 'D'},
                {'*' , 'E'},
                {')' , 'F'},
                {'\\' , 'G'},
                {'9' , 'H'},
                {'B' , 'I'},
                {'@' , 'J'},
                {'&' , 'K'},
                {'A' , 'L'},
                {'=' , 'M'},
                {'%' , 'N'},
                {'.' , 'O'},
                {',' , 'P'},
                {'{' , 'Q'},
                {'|' , 'R'},
                {'^' , 'S'},
                {'+' , 'T'},
                {'/' , 'U'},
                {'J' , 'V'},
                {'K' , 'W'},
                {'#' , 'X'},
                {'"' , 'Y'},
                {'<' , 'Z'},
                {'Z'  , ' '},

            };

            List<string> listDecode = new List<string>();
            listDecode.Add("?</|?");
            listDecode.Add("9*|=?*/^Z=.|?");
            listDecode.Add("^?%\\/B%*");
            listDecode.Add("^9*.\\.|?+9");
            listDecode.Add("V?*|=B%?");
            listDecode.Add("=?A?`?+9");

            foreach (string str in listDecode)
            {
                string decodedstring = Decode(str, Decoder);
                Console.WriteLine($"Decoded string -> {decodedstring}\n");
            }
        }

        public static string Decode(string input, Dictionary<char, char> Decoder)
        {
            string decodedString = "";
            foreach (char c in input)
            {
                input.ToUpper();
                char charDecode;
                if (Decoder.TryGetValue(c, out charDecode))
                {
                    decodedString += charDecode;
                }
                else
                {
                    decodedString += c;
                }
            }
            return decodedString;
        }





    }
}

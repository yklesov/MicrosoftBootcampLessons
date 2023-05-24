using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BasicType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string loremIpsum = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. " +
                "It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. " +
                "It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.Why do we use it? " +
                "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. " +
                "The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. " +
                "Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. " +
                "Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).";
            string text = "Similar text";

            string index = "L";

            int indexInt = 1;

            int returnResult = string.Compare(loremIpsum, text);
            Console.WriteLine("It's Compare" + " " + returnResult);

            string removeString = loremIpsum.Remove(indexInt);
            Console.WriteLine("It's Remove" + " " + removeString);

            int charIndex = loremIpsum.IndexOf(index);
            Console.WriteLine("It's IndexOf"+ " " + charIndex);

            string console = text.Insert(8, index);
            Console.WriteLine("It's Insert" + " " + console);

            string s5 = "apple";
            string s6 = "a day";
            string s7 = "keeps";
            string s8 = "a doctor";
            string s9 = "away";
            string[] values = new string[] { s5, s6, s7, s8, s9 };
            string s10 = string.Join(" ", values);
            Console.WriteLine("It's Join" + " " + s10);

            string fullText = text.Replace("text", "TEXT");
            Console.WriteLine("It's Replace" + " " + fullText);

            Console.WriteLine("It's ToLower" + " " + text.ToLower());

            Console.WriteLine("It's ToUpper" + " " + text.ToUpper());

            string countryCapital = text.Trim(new char[] { 'S' });
            Console.WriteLine("It's Trim" + " " + countryCapital);

            string[] arr = new string[]
                 {
                        "Witcher",
                        "Monster",
                        "Mortem",
                        "Murder"
                 };

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].EndsWith("r"))
                {
                    Console.WriteLine("It's EndsWith" + " " +arr[i]);
                }
            }

            StringBuilder sb = new StringBuilder(loremIpsum);
            Console.WriteLine("It's StringBuilder length" + " " + sb.Length);
            Console.WriteLine("It's StringBuilder capacity" + " " + sb.Capacity);

            loremIpsum = loremIpsum.Replace(',',' ');
            Console.WriteLine(loremIpsum);
        }
    }
}
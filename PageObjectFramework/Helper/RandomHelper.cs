namespace Framework.Test.UI.Helper
{
    public class RandomHelper
    {
        ///<summary>
        ///Return a random text
        ///</summary>
        public static string GetRandomText(int lengthOfText)
        {
            Random random = new Random();
            char[] lowserLetters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] upperLetters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] text = new char[lengthOfText];
            text[0] = upperLetters[random.Next(26)];
            for(int i=0; i< lengthOfText; i++)
            {
                text[i] = lowserLetters[random.Next(26)];
            }
            return new string(text);
        }
    }
}

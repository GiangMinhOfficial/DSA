namespace DSA_Leetcode
{
    internal class Length_of_Last_Word_58
    {
        // https://leetcode.com/problems/length-of-last-word/

        //Given a string s consisting of words and spaces, return the length of the last word in the string.

        //A word is a maximal substring consisting of non-space characters only.

        public static int LengthOfLastWord(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            int length = 0;
            bool flag = false;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    if (flag)
                        break;

                    continue;
                }
                else if (s[i] != ' ')
                {
                    flag = true;
                    length++;
                }

            }

            return length;
        }
    }
}

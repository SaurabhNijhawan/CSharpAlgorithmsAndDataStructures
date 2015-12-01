namespace DSAndAlgorithms
{
    public static class StringRelated
    {
        public static bool HasUniqueCharactersAscii(string input)
        {
            char[] charArray = input.ToCharArray();
            var ascii = new bool[256];
            foreach (char character in charArray)
            {
                if (ascii[character])
                {
                    return false;
                }
                ascii[character] = true;
            }
            return true;
        }
    }
}
public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        /*
        Idea, lo mismo que el anterior, ir metiendo todas las letras en una list e ir comprobando 
        si hay alguna repetida. Si lo hay, devuelves false
        */
        if(string.IsNullOrWhiteSpace(word))
        {
            return true;
        }

        List<char> auxStr = [];
        word = word.ToLower();

        foreach(char ch in word)
        {
            if(char.IsLetter(ch))
            {
                if(auxStr.Contains(ch))
                {
                    return false;
                }else
                {
                    auxStr.Add(ch);
                }
            }
        }

        return true;

    }
}

using System;
using System.Collections.Generic;

namespace Leetspeak
{
  public class Leetspeaks
  {
    static void Main()
    {
      Console.WriteLine("Enter text to translate into Leetspeak:");
      string userText = Console.ReadLine();
      Leetspeaks leetSpeak = new Leetspeaks();
      Console.WriteLine(leetSpeak.LeetspeakTranslation(userText));
    }

    public string LeetspeakTranslation(string text)
    {
      char[] wordOriginal = text.ToCharArray();
      char[] wordLeet = new char[wordOriginal.Length];

      for(int i = 0; i < text.Length; i++)
      {
        if(wordOriginal[i] == 'e' || wordOriginal[i] == 'E')
        {
          wordLeet[i] = '3';
        } else if(wordOriginal[i] == 'o' || wordOriginal[i] == 'O')
        {
          wordLeet[i] = '0';
        } else if(wordOriginal[i] == 't' || wordOriginal[i] == 'T')
        {
          wordLeet[i] = '7';
        } else if(wordOriginal[i] == 'I')
        {
          wordLeet[i] = '1';
        } else if((wordOriginal[i] == 's' || wordOriginal[i] == 'S') && i != 0 && wordOriginal[i-1] != ' ')
        {
          wordLeet[i] = 'z';
        } else
        {
          wordLeet[i] = wordOriginal[i];
        }
      }
      string result = string.Join("", wordLeet);
      return result;
    }
  }
}

//                                     PLAIN ENGLISH SPECS
//------------------------------------------------------------------------------------------------
//current character is 'e' or 'E' -------------------------------------> program replaces with "3"
//current character is 'o' or 'O' -------------------------------------> program replaces with "0"
//current character is 't' or 'T' -------------------------------------> program replaces with "7"
//current character is 'I' --------------------------------------------> program replaces with "1"
//current character is 's' or 'S' and not first letter of word --------> program replaces with "z"
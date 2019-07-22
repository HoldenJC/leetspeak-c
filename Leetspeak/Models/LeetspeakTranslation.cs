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
      string resultString = "";

      return resultString;
    }
  }
}

//                      PLAIN ENGLISH SPECS
//-------------------------------------------------------------------
//
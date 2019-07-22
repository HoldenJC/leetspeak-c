using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak;

namespace Leetspeak.Tests
{
  [TestClass]
  public class LeetspeakTranslationTest
  {

    [TestMethod]
    public void LeetspeakTranslation_TranslationOfE_3()
    {
      Leetspeaks testLeetspeak = new Leetspeaks();
      Assert.AreEqual("3", testLeetspeak.LeetspeakTranslation("e"));
    }


  }
}
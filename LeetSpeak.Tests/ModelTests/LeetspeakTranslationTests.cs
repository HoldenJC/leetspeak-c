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
      Assert.AreEqual("3", testLeetspeak.LeetspeakTranslation("E"));
    }

    [TestMethod]
    public void LeetspeakTranslation_TranslationOfO_0()
    {
      Leetspeaks testLeetspeak = new Leetspeaks();
      Assert.AreEqual("0", testLeetspeak.LeetspeakTranslation("o"));
      Assert.AreEqual("0", testLeetspeak.LeetspeakTranslation("O"));
    }

    [TestMethod]
    public void LeetspeakTranslation_TranslationOfT_7()
    {
      Leetspeaks testLeetspeak = new Leetspeaks();
      Assert.AreEqual("7", testLeetspeak.LeetspeakTranslation("t"));
      Assert.AreEqual("7", testLeetspeak.LeetspeakTranslation("T"));
    }

    [TestMethod]
    public void LeetspeakTranslation_TranslationOfI_1()
    {
      Leetspeaks testLeetspeak = new Leetspeaks();
      Assert.AreEqual("1", testLeetspeak.LeetspeakTranslation("I"));
      Assert.AreEqual("i", testLeetspeak.LeetspeakTranslation("i"));
    }

    [TestMethod]
    public void LeetspeakTranslation_TranslationOfS_z()
    {
      Leetspeaks testLeetspeak = new Leetspeaks();
      Assert.AreEqual("sz", testLeetspeak.LeetspeakTranslation("ss"));
      Assert.AreEqual("sz shz", testLeetspeak.LeetspeakTranslation("ss shS"));
    }


  }
}
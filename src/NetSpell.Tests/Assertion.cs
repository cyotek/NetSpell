using NUnit.Framework;

namespace NetSpell.Tests
{
  internal static class Assertion
  {
    #region Public Methods

    public static void AssertEquals<T>(string message, T expected, T actual)
    {
      Assert.AreEqual(expected, actual, message);
    }

    public static void Fail(string message)
    {
      Assert.Fail(message);
    }

    #endregion Public Methods
  }
}
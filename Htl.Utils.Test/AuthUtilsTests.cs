using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utils;

namespace Htl.Utils.Test
{
  [TestClass]
  public class AuthUtilsTests
  {
    [TestMethod]
    public void GenerateHashedPassword_CallWithPassword_ShouldGenerateCorrectHashedPassword()
    {
      string givenPassword = "p@ssw0rd1234__";

      string hashedPassword = AuthUtils.GenerateHashedPassword(givenPassword);

      Assert.IsTrue(AuthUtils.VerifyPassword(givenPassword, hashedPassword));
    }
  }
}

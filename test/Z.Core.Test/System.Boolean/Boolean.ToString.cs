// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright � ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Boolean_ToString
    {
        [TestMethod]
        public void ToString()
        {
            // Type
            bool @thisTrue = true;
            bool @thisFalse = false;

            // Exemples
            string result1 = @thisTrue.ToString("Fizz", "Buzz"); // return "Fizz";
            string result2 = @thisFalse.ToString("Fizz", "Buzz"); // return "Buzz";

            // Unit Test
            Assert.AreEqual("Fizz", result1);
            Assert.AreEqual("Buzz", result2);
        }
    }
}
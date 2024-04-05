using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TK_Aks;

namespace TK_Aks_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(TK_Aks.CalculateGrade(80), 5);
            Assert.AreEqual(TK_Aks.CalculateGrade(60), 4);
            Assert.AreEqual(TK_Aks.CalculateGrade(25), 3);
            Assert.AreEqual(TK_Aks.CalculateGrade(10), 2);
            
            //negative test
            Assert.AreNotEqual(TK_Aks.CalculateGrade(44), 2);
            Assert.AreNotEqual(TK_Aks.CalculateGrade(6), 5);
            Assert.AreNotEqual(TK_Aks.CalculateGrade(101), 5);
            Assert.AreNotEqual(TK_Aks.CalculateGrade(-55), 2);
        }
    }
}

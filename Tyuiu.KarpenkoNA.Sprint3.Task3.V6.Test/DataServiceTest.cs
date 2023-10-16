using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KarpenkoNA.Sprint3.Task3.V6.Lib;

namespace Tyuiu.KarpenkoNA.Sprint3.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds = new DataService();

            string value = "12able 1o s4gh";
            char chr = (char)1214;

            string res = ds.ReplaceNumOnChar(value, chr);

            string wait = "ttable to stgh";

            Assert.AreEqual(wait, res);


        }
    }
}

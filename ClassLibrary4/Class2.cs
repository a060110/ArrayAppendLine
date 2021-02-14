using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ClassLibrary4
{
    public class SentenceClass1
    {
        public static string SentenceMethod1(string p1)
        {
            string[] Sentence = p1.Split('\r', '\n');
            var AllSentence = new System.Text.StringBuilder();
            for (int i = 0; i <=2; i++)
            {
                AllSentence.AppendLine(Sentence[i]+"<br>");
            }
            return AllSentence.ToString();
        }
    }

    public class TestClass
    {
        [Test]
        public static void TestMethod()
        {
            string expect = "我叫賴群凱<br>\r\n正在學C#<br>\r\n請多多指教<br>\r\n";
            Assert.AreEqual(expect, SentenceClass1.SentenceMethod1("我叫賴群凱\r\n正在學C#\r\n請多多指教"));
        }
    }
}

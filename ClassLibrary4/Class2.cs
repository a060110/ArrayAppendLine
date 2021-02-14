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
            string[] Sentence = new string[3];
            Sentence[0] = "我叫賴群凱";
            Sentence[1] = "正在學C#";
            Sentence[2] = "請多多指教";
            var AllSentence = new System.Text.StringBuilder();
            for (int i = 0; i <=2; i++)
            {
                AllSentence.AppendLine(Sentence[i]);
            }
            return AllSentence.ToString();
        }
    }

    public class TestClass
    {
        [Test]
        public static void TestMethod()
        {
            string expect = "我叫賴群凱\r\n正在學C#\r\n請多多指教\r\n";
            Assert.AreEqual(expect, SentenceClass1.SentenceMethod1());
        }
    }
}

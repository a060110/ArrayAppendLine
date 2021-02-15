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
            if (string.IsNullOrEmpty(p1))
            {
                return "";
            }
                string[] Sentence = p1.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                var AllSentence = new System.Text.StringBuilder();
                foreach (string i in Sentence)
                {
                    AllSentence.AppendLine(i + "<br>");
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
        [Test]
        public static void TestMothodFourLine()
        {
            string expect= "我叫賴群凱<br>\r\n正在學C#<br>\r\n請多多指教<br>\r\n謝謝<br>\r\n";
            Assert.AreEqual(expect, SentenceClass1.SentenceMethod1("我叫賴群凱\r\n正在學C#\r\n請多多指教\r\n謝謝"));
        }
        [Test]
        public static void TestNull()
        {
            string expect = "";
            Assert.AreEqual(expect, SentenceClass1.SentenceMethod1(null));
        }
    }
}

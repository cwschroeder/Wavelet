using Wavelet.DataModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Collections.Generic;

namespace TestWavelet
{
    using System.Diagnostics;

    /// <summary>
    ///Dies ist eine Testklasse für "DataRowTest" und soll
    ///alle DataRowTest Komponententests enthalten.
    ///</summary>
    [TestClass()]
    public class DataRowTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Ruft den Testkontext auf, der Informationen
        ///über und Funktionalität für den aktuellen Testlauf bietet, oder legt diesen fest.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Zusätzliche Testattribute
        // 
        //Sie können beim Verfassen Ihrer Tests die folgenden zusätzlichen Attribute verwenden:
        //
        //Mit ClassInitialize führen Sie Code aus, bevor Sie den ersten Test in der Klasse ausführen.
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Mit ClassCleanup führen Sie Code aus, nachdem alle Tests in einer Klasse ausgeführt wurden.
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Mit TestInitialize können Sie vor jedem einzelnen Test Code ausführen.
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Mit TestCleanup können Sie nach jedem einzelnen Test Code ausführen.
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion




        /// <summary>
        ///Ein Test für "CalculateTransformedGroups"
        ///</summary>
        [TestMethod()]
        public void CalculateGroupsTest()
        {
            double[] bytes = new[] { 255.0, 0, 0, 0};
            DataRow target = new DataRow(bytes); 
            int level = 2;
            List<DataGroup> expected = new List<DataGroup>() { new DataGroup() { 127.5 }, new DataGroup() { 127.5 }, new DataGroup() { 127.5 }, new DataGroup() { 127.5 } };
            List<DataGroup> actual = target.CalculateTransformedGroups(level);

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.IsTrue(actual[i] != expected[i]);
            }
        }

        [TestMethod()]
        public void CalculateGroupsTest2()
        {
            double[] bytes = new[] { 1.0, 2.0, 3.0, 4.0 };
            DataRow target = new DataRow(bytes);
            int level = 2;
            List<DataGroup> expected = new List<DataGroup>() { new DataGroup() { 5.0 }, new DataGroup() { -2.0 }, new DataGroup() { -1.0 }, new DataGroup() { 0.0 } };
            List<DataGroup> actual = target.CalculateTransformedGroups(level);

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.IsTrue(actual[i] != expected[i]);
            }
        }

        [TestMethod()]
        public void CalculateGroupsTestPerformace()
        {
            var bytes = Enumerable.Repeat(128.0, 800).ToList();
            var levels = Math.Log(800, 2.0);
            var rowLen = this.CalculateRowLength(levels);
            while (bytes.Count() < rowLen)
            {
                bytes.Add(0x00);
            }

            var target = new DataRow(bytes.ToArray());

            var sw = Stopwatch.StartNew();
            target.CalculateTransformedGroups(Convert.ToInt32(levels));
            sw.Stop();
            Assert.IsTrue(sw.Elapsed < TimeSpan.FromSeconds(1));
        }

        private int CalculateRowLength(double levelCount)
        {
            if (Math.Abs(levelCount - Math.Floor(levelCount)) > double.Epsilon)
            {
                var newRowLength = Convert.ToInt32(Math.Pow(2.0, Math.Floor(levelCount) + 1));
                Trace.WriteLine(string.Format("Adjusted row length: {0}.", newRowLength));

                return newRowLength;
            }

            return Convert.ToInt32(Math.Pow(2.0, Math.Floor(levelCount)));
        }
    }
}

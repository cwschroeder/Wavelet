using Wavelet.DataModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestWavelet
{
    
    
    /// <summary>
    ///Dies ist eine Testklasse für "DataMatrixTest" und soll
    ///alle DataMatrixTest Komponententests enthalten.
    ///</summary>
    [TestClass()]
    public class DataMatrixTest
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
        ///Ein Test für "CalculateRowLength"
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Wavelet.exe")]
        public void CalculateRowLengthTest()
        {
            DataMatrix_Accessor target = new DataMatrix_Accessor(MatrixType.Transformed, 1); // TODO: Passenden Wert initialisieren
            double levelCount = 3.1; // TODO: Passenden Wert initialisieren
            int expected = 16; // TODO: Passenden Wert initialisieren
            int actual = target.CalculateRowLength(levelCount);
            Assert.AreEqual(expected, actual);

            levelCount = 2.0;
            expected = 4;
            actual = target.CalculateRowLength(levelCount);
            Assert.AreEqual(expected, actual);
        }
    }
}

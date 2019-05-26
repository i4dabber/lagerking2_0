using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using System.IO;

namespace CodedUITest_lagerking
{
   
    
    [CodedUITest]
    public class CodedUITest1
    {
        public TestContext TestContext { get; set; }
        public UIMap UIMap => map ?? (map = new UIMap());
        private UIMap map;
        private string _path;
        private ApplicationUnderTest _uut;

        public CodedUITest1()
        {
            _path = "../../../lagerking/bin/Debug/lagerking.exe";
            Assert.IsTrue(File.Exists(_path));
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {

            this.UIMap.NavnField_Input();
            this.UIMap.PrisField_Input();
            this.UIMap.AntalField_Input();
            this.UIMap.AfdelingField_Input();
            this.UIMap.TilfojKnap_Input();
            this.UIMap.AssertLW_Received();


        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public void MyTestInitialize()
        {
            _uut = ApplicationUnderTest.Launch(_path);
        }

        ////Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {
           _uut.Close(); 
        }

        #endregion


    }
}

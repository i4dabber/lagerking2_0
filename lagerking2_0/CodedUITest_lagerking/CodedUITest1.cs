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
using lagerking;



namespace CodedUITest_lagerking
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public TestContext TestContext { get; set; }
        public UIMap UIMap => map ?? (map = new UIMap());
        public UIMap map;
        private string _path;
        private ApplicationUnderTest _uut;
        public CodedUITest1()
        {
            _path = "../../../lagerking/bin/Debug/lagerking";
            Assert.IsTrue(File.Exists(_path));
        }

        [TestMethod]

        public void CodedUITest_FunctionTest()
        {

            this.UIMap.NavnInput_Method();
            
            this.UIMap.AssertMethod4();



        }

        [TestMethod]
        public void CodedUITest_FieldInput()
        {

            this.UIMap.NavnFelt_Input();
            this.UIMap.Prisfelt_Input();
            this.UIMap.AntalFelt_Input();
            this.UIMap.AfdelingFelt_Input();
            this.UIMap.AssertListView_Input();

        }
        [TestInitialize]
        public void MyTestInitialize()
        {
            _uut = ApplicationUnderTest.Launch(_path);
        }

        [TestCleanup]
        public void MyTestCleanup()
        {
            _uut.Close();
        }
        
     
    }
}

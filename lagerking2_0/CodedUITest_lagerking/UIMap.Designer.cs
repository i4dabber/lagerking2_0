﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 15.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITest_lagerking
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// NavnField_Method - Use 'NavnField_MethodParams' to pass parameters into this method.
        /// </summary>
        public void NavnField_Method()
        {
            #region Variable Declarations
            WpfEdit uITbxIdEdit = this.UILagerkingWindow.UITbxIdEdit;
            #endregion

            // Type 'Cola' in 'tbxId' text box
            uITbxIdEdit.Text = this.NavnField_MethodParams.UITbxIdEditText;
        }
        
        /// <summary>
        /// PrisField_Test - Use 'PrisField_TestParams' to pass parameters into this method.
        /// </summary>
        public void PrisField_Test()
        {
            #region Variable Declarations
            WpfEdit uITextBox2Edit = this.UILagerkingWindow.UITextBox2Edit;
            #endregion

            // Type '200' in 'textBox2' text box
            uITextBox2Edit.Text = this.PrisField_TestParams.UITextBox2EditText;
        }
        
        /// <summary>
        /// AntalField_Test - Use 'AntalField_TestParams' to pass parameters into this method.
        /// </summary>
        public void AntalField_Test()
        {
            #region Variable Declarations
            WpfEdit uITextBox3Edit = this.UILagerkingWindow.UITextBox3Edit;
            #endregion

            // Type '300' in 'textBox3' text box
            uITextBox3Edit.Text = this.AntalField_TestParams.UITextBox3EditText;
        }
        
        /// <summary>
        /// AfdelingField_Test - Use 'AfdelingField_TestParams' to pass parameters into this method.
        /// </summary>
        public void AfdelingField_Test()
        {
            #region Variable Declarations
            WpfComboBox uIItemComboBox = this.UILagerkingWindow.UIItemComboBox;
            #endregion

            // Select 'B' in combo box
            uIItemComboBox.SelectedItem = this.AfdelingField_TestParams.UIItemComboBoxSelectedItem;
        }
        
        /// <summary>
        /// TilfojKnap_Test
        /// </summary>
        public void TilfojKnap_Test()
        {
            #region Variable Declarations
            WpfButton uITilføjvareButton = this.UILagerkingWindow.UIItemToolBar.UITilføjvareButton;
            #endregion

            // Click 'Tilføj vare' button
            Mouse.Click(uITilføjvareButton, new Point(18, 13));
        }
        
        /// <summary>
        /// AssertList_True - Use 'AssertList_TrueExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertList_True()
        {
            #region Variable Declarations
            WpfList uILbxAgentsList = this.UILagerkingWindow.UILbxAgentsList;
            #endregion

            // Verify that the 'SelectedItemsAsString' property of 'lbxAgents' list box contains 'lagerking.Product'
            StringAssert.Contains(uILbxAgentsList.SelectedItemsAsString, this.AssertList_TrueExpectedValues.UILbxAgentsListSelectedItemsAsString);
        }
        
        /// <summary>
        /// NavnField_Input - Use 'NavnField_InputParams' to pass parameters into this method.
        /// </summary>
        public void NavnField_Input()
        {
            #region Variable Declarations
            WpfEdit uITbxIdEdit = this.UILagerkingWindow.UITbxIdEdit;
            #endregion

            // Type 'Cola' in 'tbxId' text box
            uITbxIdEdit.Text = this.NavnField_InputParams.UITbxIdEditText;
        }
        
        /// <summary>
        /// PrisField_Input - Use 'PrisField_InputParams' to pass parameters into this method.
        /// </summary>
        public void PrisField_Input()
        {
            #region Variable Declarations
            WpfEdit uITextBox2Edit = this.UILagerkingWindow.UITextBox2Edit;
            #endregion

            // Type '25' in 'textBox2' text box
            uITextBox2Edit.Text = this.PrisField_InputParams.UITextBox2EditText;
        }
        
        /// <summary>
        /// AntalField_Input - Use 'AntalField_InputParams' to pass parameters into this method.
        /// </summary>
        public void AntalField_Input()
        {
            #region Variable Declarations
            WpfEdit uITextBox3Edit = this.UILagerkingWindow.UITextBox3Edit;
            #endregion

            // Type '30' in 'textBox3' text box
            uITextBox3Edit.Text = this.AntalField_InputParams.UITextBox3EditText;
        }
        
        /// <summary>
        /// AfdelingField_Input - Use 'AfdelingField_InputParams' to pass parameters into this method.
        /// </summary>
        public void AfdelingField_Input()
        {
            #region Variable Declarations
            WpfComboBox uIItemComboBox = this.UILagerkingWindow.UIItemComboBox;
            #endregion

            // Select 'A' in combo box
            uIItemComboBox.SelectedItem = this.AfdelingField_InputParams.UIItemComboBoxSelectedItem;
        }
        
        /// <summary>
        /// TilfojKnap_Input
        /// </summary>
        public void TilfojKnap_Input()
        {
            #region Variable Declarations
            WpfButton uITilføjvareButton = this.UILagerkingWindow.UIItemToolBar.UITilføjvareButton;
            #endregion

            // Click 'Tilføj vare' button
            Mouse.Click(uITilføjvareButton, new Point(13, 17));
        }
        
        /// <summary>
        /// AssertLW_Received - Use 'AssertLW_ReceivedExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertLW_Received()
        {
            #region Variable Declarations
            WpfListItem uILagerkingProductListItem = this.UILagerkingWindow.UILbxAgentsList.UILagerkingProductListItem;
            #endregion

            // Verify that the 'DisplayText' property of 'lagerking.Product' list item contains 'lagerking.Product'
            StringAssert.Contains(uILagerkingProductListItem.DisplayText, this.AssertLW_ReceivedExpectedValues.UILagerkingProductListItemDisplayText);
        }
        
        #region Properties
        public virtual NavnField_MethodParams NavnField_MethodParams
        {
            get
            {
                if ((this.mNavnField_MethodParams == null))
                {
                    this.mNavnField_MethodParams = new NavnField_MethodParams();
                }
                return this.mNavnField_MethodParams;
            }
        }
        
        public virtual PrisField_TestParams PrisField_TestParams
        {
            get
            {
                if ((this.mPrisField_TestParams == null))
                {
                    this.mPrisField_TestParams = new PrisField_TestParams();
                }
                return this.mPrisField_TestParams;
            }
        }
        
        public virtual AntalField_TestParams AntalField_TestParams
        {
            get
            {
                if ((this.mAntalField_TestParams == null))
                {
                    this.mAntalField_TestParams = new AntalField_TestParams();
                }
                return this.mAntalField_TestParams;
            }
        }
        
        public virtual AfdelingField_TestParams AfdelingField_TestParams
        {
            get
            {
                if ((this.mAfdelingField_TestParams == null))
                {
                    this.mAfdelingField_TestParams = new AfdelingField_TestParams();
                }
                return this.mAfdelingField_TestParams;
            }
        }
        
        public virtual AssertList_TrueExpectedValues AssertList_TrueExpectedValues
        {
            get
            {
                if ((this.mAssertList_TrueExpectedValues == null))
                {
                    this.mAssertList_TrueExpectedValues = new AssertList_TrueExpectedValues();
                }
                return this.mAssertList_TrueExpectedValues;
            }
        }
        
        public virtual NavnField_InputParams NavnField_InputParams
        {
            get
            {
                if ((this.mNavnField_InputParams == null))
                {
                    this.mNavnField_InputParams = new NavnField_InputParams();
                }
                return this.mNavnField_InputParams;
            }
        }
        
        public virtual PrisField_InputParams PrisField_InputParams
        {
            get
            {
                if ((this.mPrisField_InputParams == null))
                {
                    this.mPrisField_InputParams = new PrisField_InputParams();
                }
                return this.mPrisField_InputParams;
            }
        }
        
        public virtual AntalField_InputParams AntalField_InputParams
        {
            get
            {
                if ((this.mAntalField_InputParams == null))
                {
                    this.mAntalField_InputParams = new AntalField_InputParams();
                }
                return this.mAntalField_InputParams;
            }
        }
        
        public virtual AfdelingField_InputParams AfdelingField_InputParams
        {
            get
            {
                if ((this.mAfdelingField_InputParams == null))
                {
                    this.mAfdelingField_InputParams = new AfdelingField_InputParams();
                }
                return this.mAfdelingField_InputParams;
            }
        }
        
        public virtual AssertLW_ReceivedExpectedValues AssertLW_ReceivedExpectedValues
        {
            get
            {
                if ((this.mAssertLW_ReceivedExpectedValues == null))
                {
                    this.mAssertLW_ReceivedExpectedValues = new AssertLW_ReceivedExpectedValues();
                }
                return this.mAssertLW_ReceivedExpectedValues;
            }
        }
        
        public UILagerkingWindow UILagerkingWindow
        {
            get
            {
                if ((this.mUILagerkingWindow == null))
                {
                    this.mUILagerkingWindow = new UILagerkingWindow();
                }
                return this.mUILagerkingWindow;
            }
        }
        #endregion
        
        #region Fields
        private NavnField_MethodParams mNavnField_MethodParams;
        
        private PrisField_TestParams mPrisField_TestParams;
        
        private AntalField_TestParams mAntalField_TestParams;
        
        private AfdelingField_TestParams mAfdelingField_TestParams;
        
        private AssertList_TrueExpectedValues mAssertList_TrueExpectedValues;
        
        private NavnField_InputParams mNavnField_InputParams;
        
        private PrisField_InputParams mPrisField_InputParams;
        
        private AntalField_InputParams mAntalField_InputParams;
        
        private AfdelingField_InputParams mAfdelingField_InputParams;
        
        private AssertLW_ReceivedExpectedValues mAssertLW_ReceivedExpectedValues;
        
        private UILagerkingWindow mUILagerkingWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'NavnField_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class NavnField_MethodParams
    {
        
        #region Fields
        /// <summary>
        /// Type 'Cola' in 'tbxId' text box
        /// </summary>
        public string UITbxIdEditText = "Cola";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'PrisField_Test'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class PrisField_TestParams
    {
        
        #region Fields
        /// <summary>
        /// Type '200' in 'textBox2' text box
        /// </summary>
        public string UITextBox2EditText = "200";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AntalField_Test'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class AntalField_TestParams
    {
        
        #region Fields
        /// <summary>
        /// Type '300' in 'textBox3' text box
        /// </summary>
        public string UITextBox3EditText = "300";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AfdelingField_Test'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class AfdelingField_TestParams
    {
        
        #region Fields
        /// <summary>
        /// Select 'B' in combo box
        /// </summary>
        public string UIItemComboBoxSelectedItem = "B";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertList_True'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class AssertList_TrueExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'SelectedItemsAsString' property of 'lbxAgents' list box contains 'lagerking.Product'
        /// </summary>
        public string UILbxAgentsListSelectedItemsAsString = "lagerking.Product";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'NavnField_Input'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class NavnField_InputParams
    {
        
        #region Fields
        /// <summary>
        /// Type 'Cola' in 'tbxId' text box
        /// </summary>
        public string UITbxIdEditText = "Cola";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'PrisField_Input'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class PrisField_InputParams
    {
        
        #region Fields
        /// <summary>
        /// Type '25' in 'textBox2' text box
        /// </summary>
        public string UITextBox2EditText = "25";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AntalField_Input'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class AntalField_InputParams
    {
        
        #region Fields
        /// <summary>
        /// Type '30' in 'textBox3' text box
        /// </summary>
        public string UITextBox3EditText = "30";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AfdelingField_Input'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class AfdelingField_InputParams
    {
        
        #region Fields
        /// <summary>
        /// Select 'A' in combo box
        /// </summary>
        public string UIItemComboBoxSelectedItem = "A";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertLW_Received'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class AssertLW_ReceivedExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'DisplayText' property of 'lagerking.Product' list item contains 'lagerking.Product'
        /// </summary>
        public string UILagerkingProductListItemDisplayText = "lagerking.Product";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UILagerkingWindow : WpfWindow
    {
        
        public UILagerkingWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "Lagerking";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Lagerking");
            #endregion
        }
        
        #region Properties
        public WpfEdit UITbxIdEdit
        {
            get
            {
                if ((this.mUITbxIdEdit == null))
                {
                    this.mUITbxIdEdit = new WpfEdit(this);
                    #region Search Criteria
                    this.mUITbxIdEdit.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "tbxId";
                    this.mUITbxIdEdit.WindowTitles.Add("Lagerking");
                    #endregion
                }
                return this.mUITbxIdEdit;
            }
        }
        
        public WpfEdit UITextBox2Edit
        {
            get
            {
                if ((this.mUITextBox2Edit == null))
                {
                    this.mUITextBox2Edit = new WpfEdit(this);
                    #region Search Criteria
                    this.mUITextBox2Edit.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "textBox2";
                    this.mUITextBox2Edit.WindowTitles.Add("Lagerking");
                    #endregion
                }
                return this.mUITextBox2Edit;
            }
        }
        
        public WpfEdit UITextBox3Edit
        {
            get
            {
                if ((this.mUITextBox3Edit == null))
                {
                    this.mUITextBox3Edit = new WpfEdit(this);
                    #region Search Criteria
                    this.mUITextBox3Edit.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "textBox3";
                    this.mUITextBox3Edit.WindowTitles.Add("Lagerking");
                    #endregion
                }
                return this.mUITextBox3Edit;
            }
        }
        
        public WpfComboBox UIItemComboBox
        {
            get
            {
                if ((this.mUIItemComboBox == null))
                {
                    this.mUIItemComboBox = new WpfComboBox(this);
                    #region Search Criteria
                    this.mUIItemComboBox.WindowTitles.Add("Lagerking");
                    #endregion
                }
                return this.mUIItemComboBox;
            }
        }
        
        public UIItemToolBar UIItemToolBar
        {
            get
            {
                if ((this.mUIItemToolBar == null))
                {
                    this.mUIItemToolBar = new UIItemToolBar(this);
                }
                return this.mUIItemToolBar;
            }
        }
        
        public UILbxAgentsList UILbxAgentsList
        {
            get
            {
                if ((this.mUILbxAgentsList == null))
                {
                    this.mUILbxAgentsList = new UILbxAgentsList(this);
                }
                return this.mUILbxAgentsList;
            }
        }
        #endregion
        
        #region Fields
        private WpfEdit mUITbxIdEdit;
        
        private WpfEdit mUITextBox2Edit;
        
        private WpfEdit mUITextBox3Edit;
        
        private WpfComboBox mUIItemComboBox;
        
        private UIItemToolBar mUIItemToolBar;
        
        private UILbxAgentsList mUILbxAgentsList;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIItemToolBar : WpfToolBar
    {
        
        public UIItemToolBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("Lagerking");
            #endregion
        }
        
        #region Properties
        public WpfButton UITilføjvareButton
        {
            get
            {
                if ((this.mUITilføjvareButton == null))
                {
                    this.mUITilføjvareButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUITilføjvareButton.SearchProperties[WpfButton.PropertyNames.HelpText] = "Tilføj vare";
                    this.mUITilføjvareButton.WindowTitles.Add("Lagerking");
                    #endregion
                }
                return this.mUITilføjvareButton;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mUITilføjvareButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UILbxAgentsList : WpfList
    {
        
        public UILbxAgentsList(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfList.PropertyNames.AutomationId] = "lbxAgents";
            this.WindowTitles.Add("Lagerking");
            #endregion
        }
        
        #region Properties
        public WpfListItem UILagerkingProductListItem
        {
            get
            {
                if ((this.mUILagerkingProductListItem == null))
                {
                    this.mUILagerkingProductListItem = new WpfListItem(this);
                    #region Search Criteria
                    this.mUILagerkingProductListItem.SearchProperties[WpfListItem.PropertyNames.Name] = "lagerking.Product";
                    this.mUILagerkingProductListItem.SearchProperties[WpfListItem.PropertyNames.Instance] = "5";
                    this.mUILagerkingProductListItem.WindowTitles.Add("Lagerking");
                    #endregion
                }
                return this.mUILagerkingProductListItem;
            }
        }
        #endregion
        
        #region Fields
        private WpfListItem mUILagerkingProductListItem;
        #endregion
    }
}

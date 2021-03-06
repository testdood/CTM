﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace CTM_TST.specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CTM_Energy")]
    public partial class CTM_EnergyFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CTM_Energy.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CTM_Energy", "\tIn order to compare energy prices\r\n\tAs a consumer\r\n\tI want to be be able to comp" +
                    "lete an energy comparison journey that provides energy prices", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line 7
 testRunner.Given("the user is on the \'Your Supplier\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And("the postcode field is empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.And("the Next button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("01 - Obtain gas and electricity prices - Happy Path")]
        [NUnit.Framework.CategoryAttribute("Energy")]
        [NUnit.Framework.CategoryAttribute("Electricity")]
        [NUnit.Framework.CategoryAttribute("Gas")]
        public virtual void _01_ObtainGasAndElectricityPrices_HappyPath()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("01 - Obtain gas and electricity prices - Happy Path", new string[] {
                        "Energy",
                        "Electricity",
                        "Gas"});
#line 14
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Label",
                        "Value"});
            table1.AddRow(new string[] {
                        "POSTCODE",
                        "What is your postcode?",
                        "PE2 6YS"});
            table1.AddRow(new string[] {
                        "BILL_HANDY",
                        "Do you have your bill handy?",
                        "Yes"});
            table1.AddRow(new string[] {
                        "COMPARE_UTIL",
                        "What do you want to compare?",
                        "Electricity only"});
            table1.AddRow(new string[] {
                        "SUPPLIER_ELEC",
                        "Who supplies your electricity?",
                        "EDF Energy"});
#line 15
 testRunner.When("the user has set the Your Supplier details to the following:", ((string)(null)), table1, "When ");
#line 23
 testRunner.And("the user clicks on the Next button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.Then("the user is able to progress to the \'Electricity\' section of the Your Energy step" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Label",
                        "Value"});
            table2.AddRow(new string[] {
                        "TARIFF_ELEC",
                        "What electricity tariff are you on?",
                        "Standard Variable"});
            table2.AddRow(new string[] {
                        "ECONOMY7",
                        "Do you have an Economy 7 meter?",
                        "No"});
            table2.AddRow(new string[] {
                        "PAY_TYPE_ELEC",
                        "How do you pay for your electricity?",
                        "Monthly Direct Debit"});
            table2.AddRow(new string[] {
                        "MAIN_SOURCE_ELEC",
                        "Is electricity your main source of heating?",
                        "No"});
            table2.AddRow(new string[] {
                        "USAGE_TYPE_ELEC",
                        "What is your current electricity usage?",
                        "poundSpend"});
            table2.AddRow(new string[] {
                        "USAGE_AMOUNT_ELEC",
                        "What is your current elecricity usage?",
                        "30"});
            table2.AddRow(new string[] {
                        "USAGE_PERIOD_ELEC",
                        "What is your current electricity usage?",
                        "Monthly"});
            table2.AddRow(new string[] {
                        "BILL_DATE_ELEC",
                        "Please enter the bill date which can be found...",
                        "1 January, 2017"});
#line 25
 testRunner.When("the user sets the electricity details to the following:", ((string)(null)), table2, "When ");
#line 35
 testRunner.When("the user clicks on the Next button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.Then("the user is able to progress to the \'Gas\' section of the Your Energy step", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Label",
                        "Value"});
            table3.AddRow(new string[] {
                        "TARIFF_GAS",
                        "What gas tariff are you on?",
                        "Standard"});
            table3.AddRow(new string[] {
                        "PAY_TYPE_GAS",
                        "How do you pay for your gas?",
                        "Monthly Direct Debit"});
            table3.AddRow(new string[] {
                        "MAIN_SOURCE_GAS",
                        "Is gas your main source of heating?",
                        "Yes"});
            table3.AddRow(new string[] {
                        "USAGE_TYPE_GAS",
                        "What is your current gas usage?",
                        "£"});
            table3.AddRow(new string[] {
                        "USAGE_AMOUNT_GAS",
                        "What is your current gas usage?",
                        "45"});
            table3.AddRow(new string[] {
                        "USAGE_PERIOD_GAS",
                        "What is your current gas usage?",
                        "Monthly"});
            table3.AddRow(new string[] {
                        "BILL_DATE_GAS",
                        "Please enter the bill date which can be found...",
                        "03/12/2106"});
#line 37
 testRunner.When("the user sets the gas details to the following:", ((string)(null)), table3, "When ");
#line 46
 testRunner.When("the user clicks on the Next button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
 testRunner.Then("the user is able to progress to the \'Your Details\' step", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Label",
                        "Value"});
            table4.AddRow(new string[] {
                        "PREF_TARIFF",
                        "What tariff are you interested in?",
                        "All tariffs"});
            table4.AddRow(new string[] {
                        "PREF_PAY_TYPE",
                        "What payment type are you interested in?",
                        "Monthly"});
            table4.AddRow(new string[] {
                        "EMAIL_ADD",
                        "What is your email address?",
                        "blah@blah.com"});
            table4.AddRow(new string[] {
                        "MARKETING_PERM",
                        "I agree that...",
                        "False"});
            table4.AddRow(new string[] {
                        "TERMS_CONDITIONS",
                        "Please tick this box to confirm you have read and understood...",
                        "True"});
#line 48
 testRunner.When("the user sets the \'Your Preferences\' details to the following:", ((string)(null)), table4, "When ");
#line 55
 testRunner.When("the user clicks on the \'Go to prices\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.Then("the \'Your Results\' page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Label",
                        "Value"});
            table5.AddRow(new string[] {
                        "ELECTRICITY",
                        "Electricity",
                        "EDF Energy"});
            table5.AddRow(new string[] {
                        "ELEC_TARIFF",
                        "Electricity",
                        "Standard (variable"});
            table5.AddRow(new string[] {
                        "GAS",
                        "Gas",
                        "British Gas"});
            table5.AddRow(new string[] {
                        "GAS_TARIFF",
                        "Gas",
                        "Standard"});
            table5.AddRow(new string[] {
                        "PAY_METHOD",
                        "Payment method",
                        "Monthly direct debit"});
#line 57
 testRunner.And("the \'Current tariff and usage\'  panel matches the details given by the user:", ((string)(null)), table5, "And ");
#line 64
 testRunner.And("the \'Your Results\' page contains prices", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Label",
                        "Value"});
            table6.AddRow(new string[] {
                        "PAY_TYPE_FILTER",
                        "Payment type",
                        "Monthly direct debit"});
            table6.AddRow(new string[] {
                        "TARIFF_TYPE_FILTER",
                        "Tariff type",
                        "All"});
#line 65
 testRunner.And("the filter values match the values set in the Your Preferences step:", ((string)(null)), table6, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

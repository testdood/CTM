# CTM
CTM Tech Test

This repo contains the solution files for the CTM technical test (completed using C#, Specflow, NUnit and Selenium WebDriver).
I have used a BDD framework (SpecFlow implementation) and adhered to the Page Object Model in as much as the application code is
separated out into different class files that model each page of the energy journey. The framework includes the feature file and 
scenarios, step definitions (bindings) and the application code. As per SpecFlow best practice, the application code is separated 
out into its own project so the CTM_TST solution consists of a CTM.TST.specs project (containing the features, scenarios and 
bindings) and a CTM project containing the application code classes.

The EnergyCommon.cs file has been created with the intention to capture anything that is common to all pages. Xpaths have been used 
for identifying objects; I am aware that Xpaths can lead to 'brittle' tests (if not defined well) however Xpath offers additional 
features over a CSS/ID locator strategy (such as the ability to move up the domain path as well as down). By incorporating class 
and ID attributes (as well as others) into Xpaths, it is possible to create robust locators. in my experience there is little 
difference between the two performance-wise.

With regard to the scenario steps, there is always a balance between being imperative and declarative. Rather than having separate 
steps for every action/field, I have reduced the number of steps and used tables instead. Doing this would allow the option of using 
deeper SpecFlow functionality (Assist Helpers) such as creating objects from the tables.

The solution is incomplete owing to time constraints imposed by moving house but hopefully there is sufficient to demonstrate how 
I would approach automating the energy journeys. I would also definitely be refactoring code as I progressed through the journeys 
e.g., to remove duplication with shared objects etc, utilising scenario outlines to cover permutations of data through the journey.


Pre-requisites:
Visual Studio 2015 with following packages & extensions installed:
SpecFlow.NUnit v2.1.0 package
Specflow v2.1.0 package
Selenium WebDriver v3.0.1 package
Selnium Support v3.0.1 package
Selnium WebDriver.ChromeDriver v2.27.0 package
Selenium.Firefox.WebDriver v0.11.1 package
NUnit v3.5.0 package
WebDriver.GeckoDriver v0.11.1 package
log4net v2.0.6 package
Newtonsoft.Json v.9.0.1 package
NUnit 3 Test Adapter v3.6.1.0 extension
SpecFlow for Visual Studio 2015 v2015.1.2 extension

To run the tests:
Open solution file (CTM_TST.specs.sln) in Visual Studio
Open Test Explorer window via Test/Windows/Test Explorer
In Test Explorer, right-click the feature file 01_ObtainGasAndElectricityPrices_HappyPath
Click on "Run Selected Tests" in the context menu
The test will run up to the point where the steps have not been implemented yet.



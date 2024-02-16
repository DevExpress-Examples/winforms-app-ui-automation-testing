<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/758384488/23.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1217693)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to Create UI Automation Tests for the DevExpress-powered WinForms Application

This example demonstrates how to write tests in Visual Studio 2022 using UI Automation to test the Windows Forms application with DevExpress UI controls ("UIAutomationTestingExample"). The application includes the following data forms:

* **LogIn** - simulates a call to an authorization service that asynchronously returns the user's login result (with a delay).
* **Customers** – Contains the WinForms Data Grid that displays customer information. The "Name" column displays customer names from a data source. Values in the "Is Modified" unbound column indicate whether the end-user modified customer information.

The **TestRunner** project includes 3 tests:

* `ExistingUsernameLoginTest`
* `NonExistingUsernameLoginTest`
* `ModifiedCustomerTest`

## Run Tests

In the Solution Explorer, expand the project with tests ("TestRunner"), right-click the *Tests.cs* (or *Tests.vb*) file with tests to invoke the context menu, and click "Run Tests".

## Files to Review

- [Tests.cs](./CS/TestRunner/Tests.cs) (VB: [Tests.vb](./VB/TestsRunner/Tests.vb))
- [Program.cs](./CS/UIAutomationTestingExample/Program.cs) (VB: [Program.vb](./VB/UIAutomationTestingExample/Program.vb))

## See Also

[Enhance WinForms Application Reliability with UI Test Automation](https://community.devexpress.com/blogs/winforms/archive/2024/02/15/enhance-winforms-application-reliability-with-ui-test-automation.aspx)

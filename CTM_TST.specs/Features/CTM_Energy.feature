Feature: CTM_Energy
	In order to compare energy prices
	As a consumer
	I want to be be able to complete an energy comparison journey that provides energy prices


Background: 
	Given the user is on the 'Your Supplier' page
	And the postcode field is empty
	And the Next button is disabled

@Energy
@Electricity
@Gas
Scenario: 01 - Obtain gas and electricity prices - Happy Path
	When the user has set the Your Supplier details to the following:
	| Field        | Label                        | Value            |
	| POSTCODE     | What is your postcode?       | PE2 6YS          |
	| BILL_HANDY   | Do you have your bill handy? | Yes              |
	| COMPARE_UTIL | What do you want to compare? | Electricity only |
	#| SAME_SUPPLIER | Is your gas and electricity from the same supplier? | No               |
	#| DUAL_SUPPLIER | Who supplies your energy?                           | Ignore           |
	| SUPPLIER_ELEC | Who supplies your electricity?                      | EDF Energy       |
	And the user clicks on the Next button
	Then the user is able to progress to the 'Electricity' section of the Your Energy step
	When the user sets the electricity details to the following:
	| Field             | Label                                            | Value                |
	| TARIFF_ELEC       | What electricity tariff are you on?              | Standard Variable    |
	| ECONOMY7          | Do you have an Economy 7 meter?                  | No                   |
	| PAY_TYPE_ELEC     | How do you pay for your electricity?             | Monthly Direct Debit |
	| MAIN_SOURCE_ELEC  | Is electricity your main source of heating?      | No                   |
	| USAGE_TYPE_ELEC   | What is your current electricity usage?          | poundSpend           |
	| USAGE_AMOUNT_ELEC | What is your current elecricity usage?           | 30                   |
	| USAGE_PERIOD_ELEC | What is your current electricity usage?          | Monthly              |
	| BILL_DATE_ELEC    | Please enter the bill date which can be found... | 1 January, 2017      |
	When the user clicks on the Next button
	Then the user is able to progress to the 'Gas' section of the Your Energy step
	When the user sets the gas details to the following:
	| Field            | Label                                            | Value                |
	| TARIFF_GAS       | What gas tariff are you on?                      | Standard             |
	| PAY_TYPE_GAS     | How do you pay for your gas?                     | Monthly Direct Debit |
	| MAIN_SOURCE_GAS  | Is gas your main source of heating?              | Yes                  |
	| USAGE_TYPE_GAS   | What is your current gas usage?                  | £                    |
	| USAGE_AMOUNT_GAS | What is your current gas usage?                  | 45                   |
	| USAGE_PERIOD_GAS | What is your current gas usage?                  | Monthly              |
	| BILL_DATE_GAS    | Please enter the bill date which can be found... | 03/12/2106           |
	When the user clicks on the Next button
	Then the user is able to progress to the 'Your Details' step
	When the user sets the 'Your Preferences' details to the following:
	| Field            | Label                                                           | Value         |
	| PREF_TARIFF      | What tariff are you interested in?                              | All tariffs   |
	| PREF_PAY_TYPE    | What payment type are you interested in?                        | Monthly       |
	| EMAIL_ADD        | What is your email address?                                     | blah@blah.com |
	| MARKETING_PERM   | I agree that...                                                 | False         |
	| TERMS_CONDITIONS | Please tick this box to confirm you have read and understood... | True          |
	When the user clicks on the 'Go to prices' button
	Then the 'Your Results' page is displayed
	And the 'Current tariff and usage'  panel matches the details given by the user:
	| Field       | Label          | Value                |
	| ELECTRICITY | Electricity    | EDF Energy           |
	| ELEC_TARIFF | Electricity    | Standard (variable   |
	| GAS         | Gas            | British Gas          |
	| GAS_TARIFF  | Gas            | Standard             |
	| PAY_METHOD  | Payment method | Monthly direct debit |
	And the 'Your Results' page contains prices
	And the filter values match the values set in the Your Preferences step:
	| Field              | Label        | Value                |
	| PAY_TYPE_FILTER    | Payment type | Monthly direct debit |
	| TARIFF_TYPE_FILTER | Tariff type  | All                  |

	# Xpath for Payment type filer on results page is:
	# html/body/div/div/main/section[2]//*[@class='ng-binding checked' and @for='filter-monthly-payment-type']/span










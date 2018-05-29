Feature: OctopusWebsite_OurPeople
	In order to learn about Octopus investments company's departments and people
	As a visitor
	I want to be able to visit the site and interact with the "our-people" page

Background: 
          Given  I have navigated to the our-people page

Scenario: Ensure that the page is available
	Then the page should exist

	Scenario: Ensure menu items are available
	Then I should be able to confirm the following menu Home
	| Home             |
	| Home              |
	| Our products      |
	| What we invest in |
	| Adviser centre   |
	| About us          |
	| Contact us        |

	Scenario: Ensure menu sub items are available for our products
	When I select <our-products> menu item
	Then I should be able to confirm the following <sub-menu-items>
    |our-products|sub-menu-items|
	|our products|Venture Capital trusts|
	|our products|Inheritance Tax Solutions|
	|our products|Enterprise Investment Scheme|


	Scenario: Ensure staff can be searched for by name
	And I have entered a <staff-member> into the search box
	When I hit the retrn carriage key
	Then the result should be the staff member on the screen

	Scenario: Check that team members are displayed when department tick box is ticked
	When  I  tick <department> 
	Then the <result> should be displayed on the screen
	|department|result|
	|Tax Efficient Investments team|Jess Franks|
	|Tax Efficient Investments team|Diana French|
	|Tax Efficient Investments team|Richard Payne|
	|Tax Efficient Investments team|Richard Barnes|

	Scenario: Ensure that staff members are sorted by ascending alphabetical order 
	When I select the sort in ascending order
	Then the display of staff on the page should be in ascending order

	Scenario:  Ensure that staff members are sorted by descending alphabetical order
	When I select the sort in descending order
	Then the display of staff on the page should be in descending order

	Scenario: Ensure disclaimer is displayed at bottom of page
	Then the disclaimer should be displayed in the page footer

	Scenario: Ensure links at bottom of page are displayed and function
	Then menu <links> should be displayed in the page footer
	| links                |
	| About us             |
	| Site map             |
	| Terms and conditions |
	| What we invest in    |
	| Modern Slavery Act   |
	| Privacy policy       |
	| Adviser centre       |

	Scenario: Ensure that user can switch to investments page
	When I click on the switch to investor button 
	Then the investor page should be displayed 

	Scenario: Ensure user can navigate to log in or register page
	When I click on the login/register button
	Then a secure login/register page should be displayed.

	


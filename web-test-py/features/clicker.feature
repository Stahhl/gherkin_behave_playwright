Feature: User can clicker the clicker

@fixture.playwright
Scenario Outline: User can click the clicker
  Given I am on the "Home" page
  When I click the clicker "<X>" times
  Then I should see the clicker count be "<Y>"

  Examples: Input Output
    | X             | Y       |
    | 3             | 3       |
    | 10            | 10      |
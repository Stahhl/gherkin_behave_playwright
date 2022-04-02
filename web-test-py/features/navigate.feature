Feature: Navigate

@fixture.playwright
Scenario: Goto About page
    Givet I am on the home page
    When I click the "About" link
    Then I should be on the "About" page
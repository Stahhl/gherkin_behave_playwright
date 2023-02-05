Feature: User can register on the websitesubmit

@fixture.playwright
Scenario: User regsiters correctly
    Given user is on the "registration" page
    And user enters Name correctly
    And user enters Email correctly
    And user enters Password correctly
    And user enters PasswordAgain correctly
    And user clicks submit
    Then user should be on the "home" page
from behave import *
from playwright.sync_api import expect

@when('I click the clicker "{X}" times')
def step_impl(context, X):
    for i in range(int(X)): 
        context.page.locator("[aria-label=\"Increase the counter by one\"]").click()

@then('I should see the clicker count be "{Y}"')
def step_impl(context, Y):
    y = f"text={int(Y)}"
    expect(context.page.locator(y)).to_be_visible()
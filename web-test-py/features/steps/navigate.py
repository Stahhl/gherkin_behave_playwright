from behave import *
from playwright.sync_api import sync_playwright, expect

@given('I am on the home page')
def step_impl(context):
    context.page.goto("http://localhost:3000")

@when('I click the "About" link')
def step_impl(context):
    context.page.locator("text=About").click()


@then('I should be on the "About" page')
def step_impl(context):
    expect(context.page).to_have_url("http://localhost:3000/about")

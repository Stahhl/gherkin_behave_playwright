from behave import *
from playwright.sync_api import expect

@given('user is on the "registration" page')
def step_impl(context):
    context.page.goto("http://127.0.0.1:5173/")

@then('user should be on the "home" page')
def step_impl(context):
    expect(context.page).to_have_url("http://127.0.0.1:5173/home")

@given('user enters Name correctly')
def step_impl(context):
    # Click input[type="text"] >> nth=0
    context.page.locator("input[type=\"text\"]").first.click()
    # Fill input[type="text"] >> nth=0
    context.page.locator("input[type=\"text\"]").first.fill("Nisse Nilsson")

@given('user enters Email correctly')
def step_impl(context):
    # Click input[type="text"] >> nth=1
    context.page.locator("input[type=\"text\"]").nth(1).click()
    # Fill input[type="text"] >> nth=1
    context.page.locator("input[type=\"text\"]").nth(1).fill("nisse@nilsson.se")

@given('user enters Password correctly')
def step_impl(context):
    # Click input[type="text"] >> nth=2
    context.page.locator("input[type=\"text\"]").nth(2).click()
    # Fill input[type="text"] >> nth=2
    context.page.locator("input[type=\"text\"]").nth(2).fill("password1")

@given('user enters PasswordAgain correctly')
def step_impl(context):
    # Click input[type="text"] >> nth=3
    context.page.locator("input[type=\"text\"]").nth(3).click()
    # Fill input[type="text"] >> nth=3
    context.page.locator("input[type=\"text\"]").nth(3).fill("password1")

@given('user clicks submit')
def step_impl(context):
    # Click text=Submit
    # with page.expect_navigation(url="http://127.0.0.1:5173/home"):
    with context.page.expect_navigation():
        context.page.locator("text=Submit").click()

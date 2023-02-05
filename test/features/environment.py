from behave import fixture, use_fixture
from playwright.sync_api import sync_playwright

@fixture
def setupPlaywright(context):
    # -- SETUP-FIXTURE PART:
    playwright = sync_playwright().start()
    browser = playwright.chromium.launch(headless=True, slow_mo=0, timeout=20000)
    browserContext = browser.new_context()
    context.page = browserContext.new_page()
    yield context.page
    # -- CLEANUP-FIXTURE PART:
    browser.close()
    playwright.stop()

def before_tag(context, tag):
    if tag == "fixture.playwright":
        use_fixture(setupPlaywright, context)
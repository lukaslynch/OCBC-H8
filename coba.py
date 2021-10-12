from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC

usernameStr = '820004'
passwordStr = 'LUK24091998'

browser = webdriver.Chrome()
browser.get(('https://attendance.onelabs.co/login'))

username = browser.find_element_by_name('nik')
username.send_keys(usernameStr)
# password = browser.find_element_by_name('password')
# password.send_keys(passwordStr)
password = WebDriverWait(browser, 10).until(
    EC.presence_of_element_located((By.NAME, 'password')))
password.send_keys(passwordStr)

# browser.find_elements_by_css_selector('Button_primary__1q3Nj').click()

signInButton = WebDriverWait(browser, 10).until(
    EC.presence_of_element_located((By.CSS_SELECTOR, 'Button.Button_primary__1q3Nj.Button_fullWidth__1kFG2')))
signInButton.click()
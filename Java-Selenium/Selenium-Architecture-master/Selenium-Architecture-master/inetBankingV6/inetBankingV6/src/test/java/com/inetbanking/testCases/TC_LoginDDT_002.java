//This class is actually "Complete Data Driven Test Case."
//We have added this test case to the XML file (TestNG.xml).

package com.inetbanking.testCases;

import java.io.IOException;

import org.openqa.selenium.NoAlertPresentException;
import org.testng.Assert;
import org.testng.annotations.DataProvider;
import org.testng.annotations.Test;

import com.inetbanking.pageObject.LoginPage;
import com.inetbanking.utilities.XLUtils;

public class TC_LoginDDT_002 extends BaseClass {

	// This @Test-method will take data from the below @DataProvider-method.
	@Test(dataProvider = "LoginData")
	public void loginDDT(String user, String pwd) throws InterruptedException {
		LoginPage lp = new LoginPage(driver);
		lp.setUserName(user);
		logger.info("user name provided");
		lp.setPassword(pwd);
		logger.info("password provided");
		lp.clickSubmit();

		Thread.sleep(3000);

		if (isAlertPresent() == true) {
			driver.switchTo().alert().accept();// It will close the alert
			driver.switchTo().defaultContent(); // This command will focus on the main page.
			Assert.assertTrue(false);
			logger.warn("login failed");
		} else {
			Assert.assertTrue(true);
			logger.info("Login passed");
			lp.clickLogout();
			Thread.sleep(3000);
			driver.switchTo().alert().accept(); // Close logout alert
			driver.switchTo().defaultContent(); // This will focus on the login. Then again the same method will repeat
												// multiple times.
		}
	}

	// The following is a user-defined method. I should not provide any annotation
	// for this. This method will check if alert is present or not.
	public boolean isAlertPresent() {
		try {
			driver.switchTo().alert();
			return true;
		} catch (NoAlertPresentException e) {
			return false;
		}
	}

	// Whenever we will mention @DataProvider, we must give a name to it.
	@DataProvider(name = "LoginData")
	String[][] getData() throws IOException {
		String path = System.getProperty("user.dir") + "/src/test/java/com/inetbanking/testData/LoginData.xlsx";

		int rownum = XLUtils.getRowCount(path, "Sheet1");
		int colcount = XLUtils.getCellCount(path, "Sheet1", 1);

		String logindata[][] = new String[rownum][colcount];

		for (int i = 1; i <= rownum; i++) { // Outer for-loop representing the number of rows
			for (int j = 0; j < colcount; j++) { // Inner for-loop representing the every row from the particular column
				logindata[i - 1][j] = XLUtils.getCellData(path, "Sheet1", 1, j);
			}
		}
		return logindata;
	}
}

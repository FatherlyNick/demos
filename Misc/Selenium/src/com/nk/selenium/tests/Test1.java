package com.nk.selenium.tests;

import java.util.concurrent.TimeUnit;

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.edge.EdgeDriver;

//import jdk.nashorn.internal.runtime.linker.InvokeByName;

public class Test1 {

	
	WebDriver driver;
	
	public void invokeBrowser() {
		
		System.setProperty("webdriver.edge.driver", "C:\\Users\\Niko.K\\Documents\\Selenium\\edge\\msedgedriver.exe");
		driver = new EdgeDriver();
		driver.manage().window().maximize();
		driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
		driver.manage().timeouts().pageLoadTimeout(13, TimeUnit.SECONDS);
		
		driver.get("http://www.lego2go.dx.am/");
	}
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Test1 test = new Test1();
		
		test.invokeBrowser();
		
	}

}

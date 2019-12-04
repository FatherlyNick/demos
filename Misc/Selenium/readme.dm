To configure Selenium for Java + Eclipse

1) Get latest version of Eclipse IDE (https://www.eclipse.org/downloads/)
2) Get the latest stable (non-alpha, non-beta) release of Selenium from: https://selenium-release.storage.googleapis.com/index.html
  You need 2 files: a) Selenium-java-x1.y1.z1.zip; 
                    b) selenium-server-standalone-x2.y2.z2.jar (x,y,z must match between the jars for sake of compatibility
3) Install Eclipse and create a new Java Project
4) Add Selenium into the project
  a) Right-click on the project
  b) Build path
  c) Configure build path
  d) Select Libraries tab
  e) Highlight 'Classpath' (DO NOT select module path!)
  f) Click 'Add external jars'
  g) Add selenium-server-standalone-x.y.z.jar
  h) Add all of the .jars found in the Selenium-java-x1.y1.z1.zip archive
  i) Click 'Apply and close'
5) (Optional) Now add a package and give it a conventional name
6) Add a Java class to the project
7) Import Selenium Webdriver (import org.openqa.selenium.WebDriver;
8) Write enough code to make the class compile
9) The class should compile and you should see the message <Terminated> in the Eclipse console (assuming you have the console window opened.
10) (Optional) If you do not see the Console window -> Click WIndow > Show view > Console

# AutomationFramework
Hi our Automation Framework Structure consists of 

1-Base (will be implemented in next realese) itwill have base libraries which considered as heart and soul of our framework , since here exsit all the libraries required by automation test to execute 
and it should contains :
- BasePage (or Page Object Model )
- baseStep (For step Defientions in Specflow) i am planning to use cucumber 
- Browser (For your browser)
- DeriverContext(your actual Iwebdriver object)
- TestinitializeHook (Framework gets it's life from here)

2-Config (will be implemented in next realese) : it hold all the config information required for our framwork , they can hold information reagrding to 
- which browser we are going to work with 
- which application build 
- who is executing he test

3- Extensisons (will be implemented in next realese):some special static classes which will add more power to your existing selenium webdriver libraries which enables you to "add methods to existing without creating a new derived type , recompiling , or otherwise modifying the original type it will contains:
- Webdriver Extensions 
- WebElement Extensions 

4- Helpers (will be implemented in next realese) : it will contain
helping libraries for our framework which will be used across all diffrent libraries and test projects
it will have:
-Log Helper 
-Excel Helper 
-Reporting Helper 
-Webservice Helper 
-Database Helper 


our UnitTest project to run called "Elmenus Task" it contains three steps , three pages , webdriver source
Clone project >> Open UnitTest1.cs >> Right click Run Tests



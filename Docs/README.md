### Guidance
Go to explorer y type cmd in path
in CMD type code . (Open VS Code)

- Install in VS Code
.Net Core Test Explorer 0.7.4
C# for VS studo Code
Nuget Package Manager 1.1.6

- Terminar in VS Code
dotnet new nunit
- Working on UnitTest1.cs file (Sample of unit testing code)
- View / Command Pallete 
  - Nuget add package / then type selenium and chose:
      - Selenium web Driver (3.141.0 o more stable Eg 4.9)
      - Selenium Support
      - Selenium WebDriver.Chrome Drive (Debemos ver la version actual de chrome y utilizar la misma version de preferencia)


Cada vez que instalamos una dependencia, VS Code nos sugerira restore la aplicacion
para ver que la aplicacion tiene las dependencias instalada entonces con dar click en la notificacion
de restore es suficiente. (dotnet restore)

- Lets see last option to side bar for se tests.
.NET Test explorer no encuentra nuestros test
pero si le damos play vemos que si hace el test, y se lista.


- Broware developer tools has great option tu use XPath. Just press Ctr+F and search box appers with the alternative:
Examples:
  - //input[@value='Female']
  - //table[@id='customer']/tbody/td

### Questions
What is the difference between driver.close() and driver.quit() methods in Selenium? 
- driver.close() method closes the currently active window and driver.quit() method closes all the opened windows




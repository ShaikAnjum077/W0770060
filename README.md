# Introduction

Coasters Management - This project is used to manage the coasters. Users can Add, Edit, Delete the coasters from this application.

In visual studio code 2019, we are creating a new project named MVCcoasters. 
In the Configure your new project dialog, enter MvcCoasters for Project name. And then select create. 

In the create new ASP.NET Core web application, select asp dotnet core web app model-view-controller, in dropdown select asp.net core 5.0 
Select Ctrl+F5 to run the app without the debugger.

There would be diaglogue boxes which would be popping ip need to click yes in order to download the development certificates.

Click on debug where you've to click on start without debugging from the top icons and then clicking on IIS express it will automatically open the browser with the Welcome page. 

You can run using ctrl+F5 to run the app.

We will be adding controller, In the Solution Explorer, In the Solution Explorer, right-click Controllers > Add > Controller and in that controller we are choosing MVC empty controller and thereafter MVCController empty and then add name to the controller as CoasterControllers.cs 

In the views we would be adding the views, Adding the view: On the right side of the solution explorer, right click on the view folder and then add a new folder to that folder naming as coasters. Here click on coaster folder in views and the add a new item in that select Razor View Empty and then name as Index.cshtml add modifying the code. 

We would be changing the title and footer from the layoutpage, which is found in Views/Shared/_Layout.cshtml

In the views click on home there we would be adding About us like what actually Coaster is the company details and employees and headquaters are added. 

Adding a model class as Right-click the Models folder > Add > Class. Name the file Coasters.cs and from above icons click on tools there you will find NuGetPacakeManager and then click on PackageManagerConsole and then run the commands. Running the following commands Install-Package Microsoft.EntityFrameworkCore.Design.

Now we would be Using the scaffolding tool to produce Create, Read, Update, and Delete (CRUD) pages for the Coaster model.
In Solution Explorer, right-click the Controllers folder and select Add New Scaffolded Item. In the Add Scaffold dialog, select MVC Controller with views, using Entity Framework and then Add.

Complete the Add MVC Controller with views, using Entity Framework dialog:In the Model class drop down select Coasters(MVCCoasters.Model), in the Data Class context add as MVCCoasters.Data.MVCCoasterContent. Scafffolding registers the datbaseContext. With Scafffolding it creates Controllers/CoasterController.cs. Razor view files for Create, Delete, Details, Edit, and Index pages: Views/Coasters/*.cshtml. A database context class: Data/MvcCoastersContext.cs

From the Tools menu, select NuGet Package Manager > Package Manager Console. Install the following commands: Add-Migration InitialCreate
Update-Database. Run the app if there is error occurs install few more commands SqlException: Cannot open database "MvcCoaster1" requested by the login. The login failed.

SQL Logging of Entity Framework Core. In the seeding data we would be adding 10 items to display. Then while running we would able to see the database. 

In this project we would be making a website where we can add the data when clicking on Create New also we have a database of size color price and review. We also have a About US page. 

# Technologies used

- ASP.NET CORE MVC as Web framework
- C# as Programming language
- Entity Framework core as Database interaction layer.
- CSS and Bootstarp are used for the UI Design.
- jQuery as the Front end scripting language

# Functionality

- Landing page: When the user broswers the application, by default user is navigated to Coasters listing page where user can see all the coasters added.

- Create Coaster: When the user clicks on "Create" button on the landing page, user is navigated to create coaster screen when user can add the coaster.

- Edit Coaster: When the user clicks on Edit link on the Coasters list, user is navigated to Edit Coaster screen.

- Delete Coaster: When the user clicks on Delete link on the Coasters list, user is navigated to the confirmation page to delete the coaster.

- Coaster Details: When the user clicks on Details link on the Coasters list, user is navigated to the coaster details readonly screen.
 

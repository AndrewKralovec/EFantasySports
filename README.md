#  Author 
**Andrew kralovec**, email: [akrala@yahoo.com](mailto:akrala@yahoo.com)

# About
EFantasySports is a ASP.NET CORE application with c# for the back end and Angular 2 with typescript for the front end. 
The client side code is located under the ClientApp folder in the root directory  
Webpack is being used for building and bundling client-side resources.    
Bootstrap is used for layout and styling.  
EFantasySports has migrated from Sqlite to MySQL to manager its databases. EFantasySports includes the asp.net identity framework to model and maintain the databases. The old databases can be found in the Databases folder for referance. 
Vast amount of other improvements will be made, such as hashing passwords, storing tokens, ect.     
X-unit is used for backend unit testing.  
Karma for front end unit testing.  

# Build Databases
Front end developers can use mock data instead of building the database  
Migrations should have been downloaded. Configure the database connections in appsettings.json to fit your database information.  
Create and udpate the databases with the following commands  
dotnet ef migrations add InitialCreate -c <code> dbcontextname </code>  
dotnet ef database update -c <code> dbcontextname </code>  


# Start EFantasySports 
npm install  
dotnet restore  
dotnet run  


## ASP.NET CORE Information 

## Run & Deploy

*   [Run your app](https://go.microsoft.com/fwlink/?LinkID=517851)
*   [Run tools such as EF migrations and more](https://go.microsoft.com/fwlink/?LinkID=517853)
*   [Publish to Microsoft Azure Web Apps](https://go.microsoft.com/fwlink/?LinkID=398609)


## TODO
Update to the new versions of angular & asp.net core 

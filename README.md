This project is developed in Visual Studio 2022 with Core 3.1, using EntityFramework for DB operations and Docker for deployment.</br>
Microservices are implemented in different languages like C# and F# </br>
Each Microservices has seperate DB connection, Docker images and running simultaneouly on seperate port. </br>

Important command for migrating DB script and update DB. Need to execute these command in **Package Manager Console** in Visual Studio.<br/>
**<code>Add-Migration InitialCreate </br>
update-database</br></code>**

If there is multiple DBContext in a single Microservices use below command to create Migration </br>
<code>Add-Migration AnythingMigrationName -Context DBContextName</br>
update-database -Context DBContextName</code></br>
where DBContextName is conetext name of the microservices

For removing Migration: </br>
**<code>Remove-Migration -Context StudentContext</code>**

To create Docker Images run the below command in **Package Manager Console**<br/>
**<code>dotnet publish /p:PublishProfile=DefaultContainer</code>**

This project is developed in Vidual Studio 2022 with Core 3.1, using Docker for deployment.</br>
Each Microservices has seperate DB connection, Docker images and running simultaneouly on seperate port. </br>

Important command for migrating DB script and update DB. Need to execute these command in **Package Manager Console** in Visual Studio.<br/>
**<code>Add-Migration InitialCreate </br>
update-database</br>
Add-Migration StudentMigration -Context StudentContext</br>
update-database -Context StudentContext</code>**</br>

For removing Migration: </br>
<code>Remove-Migration -Context StudentContext</code>

To create Docker Images run the below command in **Package Manager Console**<br/>
<code>dotnet publish /p:PublishProfile=DefaultContainer</code>

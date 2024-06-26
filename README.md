This project is developed in Visual Studio 2022 with Core 3.1, using EntityFramework for DB operations and Docker for deployment.</br>
Microservices are developed in seperate languages using C# and F#. </br>
Each Microservices has seperate DB connection, Docker images and running simultaneouly on seperate port. </br>

Once you clone this project it will include all referances and migration script. Just need to update Data Source in connection string in _appsettings.json_ in each project that have DB connection.<br/>
Once you set DB cource. Set project as startup project and run command <code>update-database</code> in _Package Manager Console_ to create db and tables as per migration<br/>
repeat the same for every project that have DB connection to create DB.<br/>

Install these below packages if not included </br>
<code>Install Microsoft.AspNetCore.App 2.1.34 </br>
Install-Package Microsoft.EntityFrameworkCore.Tools -Version 5.0</br>
Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 5.0</br>
Install-Package Microsoft.EntityFrameworkCore.SqlServer.Design</br></code>

Important command for migrating DB script and update DB. Need to execute these command in _Package Manager Console_ in Visual Studio.<br/>
**<code>Add-Migration InitialCreate </br>
update-database</br></code>**

If there is multiple DBContext in a single Microservices use below command to create Migration </br>
<code>Add-Migration AnythingMigrationName -Context DBContextName</br>
update-database -Context DBContextName</code></br>
where DBContextName is conetext name of the microservices

For removing Migration: </br>
**<code>Remove-Migration -Context DBContextName</code>**
where DBContextName is conetext name of the microservices

To create Docker Images run the below command in *Package Manager Console*<br/>
**<code>dotnet publish /p:PublishProfile=DefaultContainer</code>**
<br/>
Once Docker Images created successfully, verify images on CMD using command **<code>docker images</code>** or install <a href="https://docs.docker.com/desktop/install/windows-install/">Docker Desktop</a>

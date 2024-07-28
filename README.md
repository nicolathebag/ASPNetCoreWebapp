# Aspnet MVC web application deploy on clod run service 



## Web application development 



As a POC it has been developed a web application to read store and edit a bucket of objects.



Main changes made on ASPNet Core web application of Visual Studio starter projects:

	• added CartItem model , CRUD views and Controller scaffold classes,

	• changed Home Layout title

	• added connection string builder getting them from environment vars



## GCP configuration



It has been used GCP platform to build and deploy web application.



On GCP platform I created

	• a Cloud run service instance , adding env vars 

	• SQL server instance 

And since it's not possible to connect an SQL server to a Cloud run service through public IP 

	• Vpc subnet and connector instances



## Build and deploy on Dockerfile



I used Docker windows images containers as environment to build the web application artifacts.



It's been used dotnet command lines functionalities on the windows container to build restore and publish artifacts of the web application.



These steps are implemented in Dockerfile.



## CI/CD Trigger on GitHub 



Once uploaded the project on a GitHub repo I set a CI/CD a trigger on GitHub on main branch and configured Dockerfile custom local file as step build.



Repo : https://github.com/nicolathebag/nlosacco4/tree/main



Deployed web application:

https://quickstart-service-qsau3ru34q-uc.a.run.app/

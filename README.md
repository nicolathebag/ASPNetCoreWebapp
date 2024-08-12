# Aspnet MVC web application deploy on clod run service 



## Web application development 



This is an example of a basic web application to read store and edit a bucket of Items, preserving data on a DB.



The main changes applied on ASPNet Core web application of Visual Studio starter project are:

* added CartItem model , CRUD views and Controller scaffold classes,

* changed Home Layout title,

* added connection string builder function that get values from environment (from GCP dotnet sample projects).



## GCP configuration



It has been used GCP platform to build and deploy web application.



On GCP platform I created

* a Cloud run service instance , adding env vars in order to connect to a

* SQL server instance 

And since it's not possible to connect an SQL server to a Cloud run service through public IP 

* Vpc subnet and connector instances



## Build and deploy on Dockerfile



I used Docker windows images containers as environment to build the web application artifacts.



It's been used dotnet command lines functionalities on the windows container to build restore and publish artifacts of the web application.



These steps are implemented in Dockerfile.

These steps :
  RUN apk add icu-libs
  ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false

to solve CultureInfo issues of aspnet framework 



## CI/CD Trigger on GitHub 



Once uploaded the project on a GitHub repo I set a CI/CD trigger on my GCP Cloud run instance.
As a custom build step I set the Dockerfile.




Deployed web application:

https://quickstart-service-qsau3ru34q-uc.a.run.app/

added swagger on root page

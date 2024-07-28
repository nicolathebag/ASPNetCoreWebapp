# Aspnet MVC web application deploy on clod run service 



## Web application development 



This is a basic web application to read store and edit a bucket of Items, preserving data on a DB.



The main changes applied on ASPNet Core web application of Visual Studio starter projects are:

* added CartItem model , CRUD views and Controller scaffold classes,

* changed Home Layout title

* added connection string builder getting them from environment vars



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



## CI/CD Trigger on GitHub 



Once uploaded the project on a GitHub repo I set a CI/CD a trigger on GCP Cloud run instance setting also Dockerfile as Build step configuration.




Deployed web application:

https://quickstart-service-qsau3ru34q-uc.a.run.app/

# .NET Core Microservices [Video]
This is the code repository for [.NET Core Microservices [Video]](https://www.packtpub.com/application-development/net-core-microservices-video?utm_source=github&utm_medium=repository&utm_campaign=9781788626415), published by [Packt](https://www.packtpub.com/?utm_source=github). It contains all the supporting project files necessary to work through the video course from start to finish.
## About the Video Course
Microservices are an architectural style that promotes the development of complex applications as a suite of small services based on business capabilities. This course will help you identify the appropriate service boundaries within the business.

We'll start by looking at what microservices are, and their main characteristics. We will develop a basic distributed system using the microservice architecture and tools such as RabbitMQ service bus, to send messages across the separated services, or MongoDB, which is a NoSQL database. Within the course, we will focus on creating the HTTP API to act as a gateway to the whole system and so-called Activities Service, responsible for handling the incoming messages (or actually the commands that will be distributed through the services bus). We'll also implement the Identity Service, which will serve JSON Web Tokens (JWT) to authenticate requests incoming to the API. Our application will let the user store information about the activities performed at a given date for a selected category, for example, work, tasks, sport, and so on.

Once the request to save the activity is published within the system, the Activities Service will handle the business logic and decide whether the activity is valid, which will eventually result in publishing the event about processing the successful or rejected activity. In the course, you will also learn about commands and events as well as handlers which is one of the most popular design patterns when it comes to creating distributed systems.

By the end of the course, your services will be built using ASP.NET Core framework and later on, you will use tools such as Docker and Docker Compose to pack your application into the container and deploy it to the virtual machine running in the cloud.

<H2>What You Will Learn</H2>
<DIV class=book-info-will-learn-text>
<UL>
<LI>Explore the Docker commands to use for your application 
<LI>Build Container images with the docker command line 
<LI>Explore the Dockerfile and docker build 
<LI>Tag and run your first Docker image 
<LI>Customize the dockerfile in your .net application 
<LI>Add your database and link the containers 
<LI>Write a build script to make your .NET core application data-driven and robust 
<LI>Debug images into a container using Visual Studio 
<LI>Use the kops tool to create a Kubernetes cluster in AWS 
<LI>Deploy an image with kubectl in your application </LI></UL></DIV>

## Instructions and Navigation
### Assumed Knowledge
To fully benefit from the coverage included in this course, you will need:<br/>
<LI>Good knowledge of the C# programming language
<LI>Basic understanding of .NET Core platform
<LI>Basic understanding of HTTP API and distributed systems
### Technical Requirements
This course has the following software requirements:<br/>
<LI>An IDE or editor likeVisual Studio, Visual Studio Code, Atom, Sublime Text etc.
<LI>OmniSharp (if not a full Visual Studio is being used)
<LI>.NET Core 2.0 or higher
<LI>Docker


## Related Products
* [C# 7 and .NET Core 2.0 Recipes [Video]](https://www.packtpub.com/application-development/c-7-and-net-core-20-recipes-video?utm_source=github&utm_medium=repository&utm_campaign=9781787289444)

* [Full Stack .NET Web Development [Video]](https://www.packtpub.com/web-development/full-stack-net-web-development-video?utm_source=github&utm_medium=repository&utm_campaign=9781788291514)

* [Docker for ASP.NET Core MVC [Video]](https://www.packtpub.com/virtualization-and-cloud/docker-aspnet-core-mvc-video?utm_source=github&utm_medium=repository&utm_campaign=9781788831468)


# Clean-Architecture-CQRS-Starter
##### This a starter project which is based on create a clean architecture project with CQRS MediatR

## What is Clean Architecture?
##### Clean Architecture is an architecture pattern aimed at building applications that we can maintain, scale, and test easily.

##### It achieves this by separating the application into different layers that have distinct responsibilities:

![image](https://github.com/user-attachments/assets/b090e045-83de-4041-a52e-e1e88df12db6)

* Domain Layer – The domain layer represents the application’s core business rules and entities. This is the innermost layer and should not have any external dependencies. 
* Application Layer – The application layer sits just outside the domain layer and acts as an intermediary between the domain layer and other layers. In other words, it contains the use cases of the application and we expose the core business rules of the domain layer through the application layer. This layer depends just on the domain layer.
* Infrastructure Layer – We implement all the external services like databases, file storage, emails, etc. in the infrastructure layer. It contains the implementations of the interfaces defined in the domain layer.
* Presentation Layer – The presentation layer handles the user interactions and fetches data to the user interface.
  
***A fundamental principle of Clean Architecture is that the dependencies should point from the concrete outer layers to the abstract inner layers.***

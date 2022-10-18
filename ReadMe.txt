I don't have .NET 6 and Visual Studio 2022 on my laptop and hence I did the development using .NET 5 and Visual Studio 2019. 

I used a 3 tier architecture to write the application.
1. BasketGenerator - Presentation layer
2. BasketGeneratorBLL - Business logic layer
3. BasketGeneratorDAL - Data access layer

I hard-coded the data in GameData class to feed and run the application.
I did not have time to write the unit tests so I skipped them. Also, I felt like it does not make sense to write unit tests as the application runs from hard-coded data. 

Program.cs file is the entry point and once the project is run from Visual Studio, the output will appear. 

This program will work with any number of team seeds (16, 64, etc) and it will work once the data is properly fed from GameData class. 
I decided the winner randomly using a random number generation logic (1 or 2 and based on that team 1 or team 2 will win) and based on that let the application move forward with selecting the winners, arranging matches with winners, and so on until only 1 winner remains. 
It was not very clear to me how the winning logic should be built however I built a logic based on assumptions.
My main focus was to get the desired outcome and did not try to implement all best practices unnecessarily. I spent around 6 hours completing the task.  

The Singleton design pattern was used to create the central objects and make sure that they are not duplicated. 
I used interfaces and classes to write the logic and tried to use the Single Responsibility Principle as far as possible and tried to give only one responsibility for one class. 
Then used interface-typed objects everywhere to follow Open Closed Principle later in the life cycle when necessary. 
Dependency injection has been used widely to inject abilities that are not available in the classes and to enrich functionality. Constructor injection was used mainly. 
I used LinkedList to determine the winner and print the winning path. 
Also, dictionaries and lists were used here and there as temporary storage.
Sting interpolation and LINQ queries were also used based on the requirement. 


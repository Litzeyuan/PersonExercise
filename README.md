# PersonExercise
•	Please clone the repository to your local pc and use Visual Studio to open the solution PersonOperation.sln under the PersonOperation folder

•	You can find the main ASP.NET Core Web Application project PersonOperation and the test project PersonOperation.Test.

•	You can find all the unit tests for each action under the PersonOperation.Test project
  
•	By running the project PersonOperation, it will be deployed to the URL https://localhost:5001/swagger/  and all api endpoints will be displayed by integrating with the Swashbuckle. Alternatively, you can use Postman to test those endpoints:

  o	POST action, add a new Person: https://localhost:5001/api/person/add
    
   payload
      
      {
      "id": 1,
      "firstName": "Homer",
      "lastName": "Simpson"
      }
  
  o	PUT action, edit a Person: https://localhost:5001/api/person/edit
  
   payload
      
      {
        "id": 1,
        "firstName": "Max",
        "lastName": "Power"
      }

   
   o DELETE action: delete a Person by id: https://localhost:5001/api/person/delete/1
   
   o GET action: get the count for all persons: https://localhost:5001/api/person/countAll
   
   o GET action: get all persons: https://localhost:5001/api/person/getAll


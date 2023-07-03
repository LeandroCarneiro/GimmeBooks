# GimmeBooks
This project has an API that show a cross referency of news and books. On the solution you can find a time trigger that runs every minute to get news from NY times and books from Google Books that can help the reader.

It is a code first application the will create a database locally when you run the app for the first time. 
The context has only one entity that stores an analize of how many tweets and books were found related to the news from New York Times.



DDD Structure:
- Domain
- Common
- Business

  --Presentation layer
    - API
    - TimeTrigger
    - Application
    - ViewModels
    
  --Infra
    -- External
      - GoogleBooks
      - Twitter
      - NYNews
    - Bootstrap
    - Data
    - DI
    - Mapper
    
 #Cypress

To test an API using Cypress, you can follow these steps:

Install Cypress: Cypress is a JavaScript-based end-to-end testing framework. You can install it using the Node Package Manager (NPM). Here's an example of how to install Cypress globally:

 npm install -g cypress


Create a new Cypress project: Once Cypress is installed, you can create a new Cypress project by running the following command in your project directory:
  npx cypress open


# PROJECT: ImHungry
This is my repository for a web application I will be developing, *I'm Hungry*! 
This web application was created throughout the Microsoft Software and Systems Academy, Cloud App Developer Program, Cohort 8.

---

## I'm Hungry Description
* The purpose of I'm Hungry is to connect open-minded individuals with local food establishments.
* This is done by connecting users with APIs, such as Yelp!'s REST API, through an easy to use web-based application.
* Users can search using two options: 
  * geolocation input from their device
  * manual zipcode input.
* Users will have the option of adjusting their search radius to provide nearby food establishments.
* Users will receive a random nearby food establishment and decide to *keep* or *try again*.
* If a User decides to *keep* the location they are given, they will be given further information regarding that establishment.

---

## Task List
- [X] Formal Investigation
- [X] Application Presentation | [Download Here](https://github.com/PerezDC/ImHungry/blob/master/ImHungry%20Presentation.pptx)
- [X] Database Conceptual Design (ERD)
- [X] Database Creation (SQL Scripts) | [See Here](https://github.com/PerezDC/ImHungry/blob/master/ImHungryDatabase.sql)
- [X] UI/UX (Wire-frame sketches)
- [X] Identify User Stories
- [X] Identify Use Cases
- [X] Use-Case Diagram (UML)
- [X] Requirements List

---
## Entity Relationship Diagram
![ImHungryERD](https://github.com/PerezDC/ImHungry/blob/master/I'm%20Hungry%20ERD.png)

---
## Wire-frames
![Wireframe1](https://github.com/PerezDC/ImHungry/blob/master/Wireframe%201.PNG)
![Wireframe2](https://github.com/PerezDC/ImHungry/blob/master/Wireframe%202.PNG)
![Wireframe3](https://github.com/PerezDC/ImHungry/blob/master/Wireframe%203.PNG)
![Wireframe4](https://github.com/PerezDC/ImHungry/blob/master/Wireframe%204.PNG)

---
## User Stories
ID | User Story
---|-----------
1.1|As a user, I want to browse local restaurants so that I can experience restaurants I typically will not visit.
1.2|As a user, I want to search for restaurants using my device’s location so that I do not have to manually type in a zip code.
1.3|As a user, I want to search for restaurants using a typed in zip code so that I do not have to share my device’s current location.
1.4|As a user, I want to adjust my search radius so that I can find a nearby restaurant within a specific distance.
1.5|As a user, I want to save my recently visited restaurants so that I can visit again in the future.

---
##  Use Cases
ID | Use Case
---|---------
2.1|Given user visits home page, when they click ‘Log In’, show login form.
2.2|Given user visits home page, when they click ‘Continue as Guest’ button, direct to search page.
2.3|Given user visits home page, when they click ‘Not a member?’ link, show user registration form.
2.4|Given user action, when they login, display welcome back message with their last visited restaurant and ‘like’ or ‘dislike’ button.
2.5|Given user action, when they click the ‘Use my location’ button, devices geolocation is received from device if allowed.
2.6|Given user action, when they click the ‘Search by ZIP’ button, display Input Zip Code form.
2.7|Given user action, when they click the ‘Settings’ button, display user settings list.
2.8|Given user action, when they select a search option, display results page.
2.9|Given user action, when they select ‘Spin Again’ button, display new random result from search query.
2.10|Given user action, when they select ‘Directions’ button, reroute user to directions application of their choice.

---
## Use-Case Diagram (UML)
![UML-initial](https://github.com/PerezDC/ImHungry/blob/master/ImHungry%20Use%20Case%20Diagram.PNG)

---
## Requirements List
ID | Requirement
---|------------
3.1.|System shall allow registered users to log in.
3.1.1.|System shall allow registered users to input username and password.
3.1.2.|System shall validate login credentials in database.
3.1.3.|System shall forward validated users to welcome page.
3.2.|System shall allow users to continue as guest.
3.2.1.|System shall forward guest to search page.
3.3.|System shall allow users to register an account.
3.3.1.|System shall allow users to input new login credentials.
3.3.2.|System shall validate input formatting.
3.3.3.|System shall forward newly registered users to welcome page walk-through.
3.4.|System shall allow registered users to rate last visited location.
3.5.|System shall allow users to provide a search location.
3.5.1.|System shall allow users to provide device geolocation if appropriate button is clicked.
3.5.2.|System shall provide users with zip code input form if appropriate button is clicked.
3.5.2.1.|System shall validate input is in correct format.
3.5.3.|System shall forward users to results interface once search location data has been inputted.
3.6.|System shall allow users to adjust search radius with slider.
3.7.|System shall submit formatted query to REST API.
3.7.1.|System shall index search results into user database.
3.7.2.|System shall filter results from query and delete restaurants rated as ‘disliked’.
3.8.|System shall display results interface and implement database results.
3.8.1.|System shall present a random result to user.
3.8.2.|System shall allow user to fetch a new random result if button is clicked.
3.8.3.|System shall save last result as visited if application is closed or left idle.

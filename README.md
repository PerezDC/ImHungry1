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
- [X] Software Requirements Table

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

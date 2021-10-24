# Recruiter-Assessment
Coin Jar
This project is the assessment for a recruiter. 
the project does not have a database that needs to be setup and run

Please ensure that the nuget packages are restored at the time of pulling down the code. Thereafter, just run it and the swagger page will open with 3 endpoints:
1. to add coins to the Jar
2. to get the total amount of coins in the jar 
3. to reset the jar

The solution Structure:

BLL
This project houses the logic and validation to add to the coin jar

Unit Test
This project runs a simple test to add and get the values from the coin jar


API
This project encompasses the api endpoints via swagger. This calls the BLL 

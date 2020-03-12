# Reach Web Application
## Overview
This Application is meant to be used with the Bluetooth Gateway created for Gateworks.
The provided code is based off the example given here: 
https://docs.microsoft.com/en-us/azure/app-service/app-service-web-tutorial-dotnet-sqldatabase

## Notes
Building this web application requires the use of Visual Studio, MySQL for Visual Studio, and a MySQL
database. Connection strings must be updated to connect to an existing database.
Once a MySQL database server and database have been created, the commands below can be used to create the necessary tables using the MySQL command prompt:

```CREATE TABLE config (postrate INT, realtime CHAR(1), ID INT, PRIMARY KEY (ID));```

```CREATE TABLE messages (msg VARCHAR(140), created_at DATETIME DEFAULT CURRENT_TIMESTAMP);```

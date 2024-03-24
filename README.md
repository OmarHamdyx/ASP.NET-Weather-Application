Weather App
===========

This project is an ASP.NET Core web application that displays weather details for selected cities. It utilizes services and dependency injection to manage weather data.

Table of Contents
-----------------

*   [Introduction](#introduction)
*   [Features](#features)
*   [Usage](#usage)
*   [Setup](#setup)
*   [Dependencies](#dependencies)


Introduction
------------

The Weather App is designed to provide users with weather details for three cities: London, New York City, and Paris. It retrieves weather data from a hardcoded dataset and displays it on the web interface.

Features
--------

*   View weather details for all cities
*   View weather details for a specific city
*   Error handling for invalid city codes
*   Responsive UI with modern design
*   Background color indication based on temperature

Usage
-----

### Viewing Weather Details

*   To view weather details for all cities, navigate to the root path ("/").
*   To view weather details for a specific city, navigate to "/weather/{cityCode}" where `{cityCode}` is the unique code for the desired city (e.g., "LDN" for London).

### Error Handling

*   If an invalid city code is provided in the route parameter, an error message will be displayed instead of an exception.

Setup
-----

1.  Clone the repository to your local machine(Master is main project and first branch is dependencies)
2.  Open the project in Visual Studio or any preferred code editor.
3.  Build and run the project.

Dependencies
------------

*   ASP.NET Core


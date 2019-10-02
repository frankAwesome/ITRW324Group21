# ITRW324Group21

API:
REST-ful API. It is a model first API. So the database (if not create) will be created on debug. We used dotnet core 2.1 for the coding of the API.  Pretty easy stuff considering people spending weeks on SOAP web services. We receive JSON from the API. Parameters include: few text fields, id, and urls pointing to the uploaded images. The API is coded to provide the latest announcement uploaded by accessing the default url (or endpoint).
We initially used SQL server. That worked fine till we needed to host the API. We now use SQlite. This is much more portable. We are currently hosting on an Windows Server machine with the help of IIS and the dotnet hosting bundle. We will obviously try to host this thing on Linux because at the moment we are just wasting resources.
So in short the API is hosted on the internet. The application can be installed on any computer, and the latest data will be pulled from the database connected to the API, through internet connection.

Client:
So this API will connects to multiple clients. Think of it as an eFundi type announcement sent to all computers owned by a company. All clients update instantly via the API.
Plain old C# using HTTP Client with the help of Nugets: Microsoft.API.Client and Newtonsoft JSON.
The loading animation was a tough one. A separate form was created running in a separate thread. Otherwise this animation stutters. Opacity is then used to turn the top form invisible to visible with the help of a timer.
The round edges are done with an SDK. (edited) 



# Installation

2. Run *audiocapturesetup.exe* to install neccessary audio drivers for voice note capabilties



# Documentation Notes
  
    1 - Front Page
        - student nrs, names, project name, picture/logo, first impression 
        - Impression mark +- 10%
        - Aesthetic coloring/styling   
        
    2 - Index
        - table of contents for everything
        - list of tables
        - list of figures
        
    3 - Abstract (optional) complete summary of the project/introduction/conclusion etc.
    
    4 - Introduction
        - problem statement
        - solutions and alternatives
        - possible outcomes of solutions
        - project goal
        
    5 - Background
        - research
        
    6 - REFERENCING!
        - reference all facts/statements
        - in text & in bibliography
        
    7 - Project approach
        - describe/discuss project goals
        - swot anaylsis/gantt chart/schedule
        - member role definitions
        - extract from project proposal
        - hardware/software specifications
        - client/server description
        
    8 - Results & discussion of results
    
    9 - Conclusion
        - Formal conclusion of project
        
    10 - Reflection (optional)
        - What you enjoyed/struggled with
        - member morale/teamwork comments
        - Demi situation
        
    11 - Supporting documents/screenshots/images/error messages
    

Application name: DataExtract
Application Type:  Console
Purpose:  Read a JSON file, parse the file and extract certain data elements from it and calculate the sum of those items.  The logic is to compute the sum of Id only when the Label item is not null
Datasource:  It reads the JSON file whose name is defined in the app.config file.  The Json file is copied to the application folder during a build.  

Deployment:  Copy the executable DataExtract.exe along with DataExtract.exe.config and CodeTest.json to a folder and run
Output:  The application output is written to the console window.  The user needs to press any key to close the console window

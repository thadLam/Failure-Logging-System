# Failure-Logging-System
## Motivation
To reinvent and optimize the failure logging system to encourage frequent use and ease of use.

## Instructions
1. Open the Failure Logging System application (this opens a command prompt detailing what port it's listening on, this will be used in step 3!)
2. Navigate to any web browser
3. In the URL field, type in "localhost:(portnumber)" replace (portnumber) with the portnumber found in step 1
![image](https://github.com/thadLam/Failure-Logging-System/assets/135151735/d194d9e4-9edb-421e-be66-b2386a561f8e)

## Useful command codes
to build a self-contained .NET application:
dotnet publish --framework net6.0 -o "C:\Users\thaddaeusl\Desktop\Failure-Logging-Application" --sc

-f|--framework 
publishes the application for the specified target framework
-o|--output
specifies the path for the output directory
--sc|--self-contained [true|false]
publishes the .NET runtime with your applicaiton so the runtime doesn't need to be installed on the taret machine

for more command options:
https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-publish


# <h1 align = "center"> Cretaceous Park API

##### <h4 align = "center">  Building an API for Epicodus, 08.17.2020

#### <h4 align = "center"> By _**Joseph Pearce & Christine Augustine**_

## Description

Building an API practice 

## Setup/Installation Requirements 

### 1. Install .NET Core 

Download .NET Core SDK from Microsoft Corp  (**[macOS](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer) | [Windows OS](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer)**)

### Install dotnet script

Enter the command `dotnet tool install -g dotnet-script` in Terminal 

### 2. Clone this [repository](https://github.com/christinereina/Wonka.Solution) from GitHub
```
cd desktop
git clone 
cd CretaceousPark.Solution
```
### 3. Install the necessary dependencies to build the project, run the following commands in your Terminal:
```
dotnet restore
dotnet build
dotnet run 
```
### 4. Create the database and project tables
```
dotnet ef migrations add Initial
dotnet ef database update
```
### 5. Starting the Server

Initialize a local server to run the project in your browser
```
dotnet watch run
```

If you are running the script locally, it will open the project in your browser window and shift the focus from the terminal to the browser. If not, you can copy and paste this address to view:

```
http://127.0.0.1:5000
```


## Known Bugs


## Support and contact details

Please feel free to contact the author through GitHub **[christinereina](https://github.com/christinereina)** with any feedback, questions or concerns.


## Technologies Used

* C# 
* .NET-Core 2.2
* ASP.NET Core MVC
* MySQL
* EF Core
* ASP.NET Core Identity
* Razor 2.2.0
* Visual Studio Code
* Git Version Control 
* GitHub


### License

[MIT](https://mit-license.org/)

Copyright (c) 2020 **Joseph Pearce & Christine Augustine**
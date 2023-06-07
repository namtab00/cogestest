# Coges Test - Quiz

Coges Test - Quiz answering application

Uses:

* .NET 6
* Azure Cosmos DB Emulator for persistence
* Blazor Server for UI

## Prerequisites


### .NET 6 SDK
The .NET 6 SDK must be installed in order to compile and run the application.

If not already present, it can be installed via winget with:

```powershell
winget install Microsoft.DotNet.SDK.6
```

### Azure Cosmos DB Emulator

If not already present, it can be installed:

* either manually download and install the [Azure Cosmos DB Emulator](https://learn.microsoft.com/azure/cosmos-db/local-emulator)
* or install it via `winget` with the following command:
    ```powershell
    winget install Microsoft.Azure.CosmosEmulator
    ```
Once installed, **open the Azure Cosmos DB Emulator**

## Instructions for running the application

* Clone this repo.

* Start the application by:
  * either opening a Powershell terminal in the repository root and running
    ```powershell
    .\run.ps1
    ```
  * or opening the /CogesTest.sln solution with Visual Studio 2022 and launching with or without debugging

**At application startup, the database is created and a set of 5 quizzes is seeded.**


Visit the application at [https://localhost:65244](https://localhost:65244).

You should be greeted by this UI:
![Homepage](/.wiki/images/Screenshot_2023-06-09_234344.png?raw=true&cachebust "Homepage")

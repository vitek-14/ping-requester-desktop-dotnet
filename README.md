# Ping Requester

Looking for an instalator? See [Installation](#installation) section for more information!

## Description

Ping Requester is a lightweight desktop tool for pinging web domains or IPv4 addresses. The tool utilizes the standard Windows Command Line 'ping' command for its core functionality. Users can configure various ping parameters and enable notifications for successful requests. Results can be viewed in the main panel or via the console output, which can also be saved as a log file. Furthermore, ping results can be stored in a local database, allowing users to track their request history. Settings and user preferences (presets) can be easily saved for future use.

## Why create such a tool?

This project originated from my interest in learning .NET. I wanted to build a desktop application, and since I was experiencing network issues at my residence at the time, I decided to create a custom tool for pinging specific targets. While the scope is focused, I was eager to implement various technologies such as Entity Framework Core, SQLite, and explore the capabilities of the C# language and .NET. This project also represents my first experience building a larger application using a 3-layer architecture.

This project was also used as a semestral work for a course at the Faculty of Applied Sciences, University of West Bohemia. Thanks to it I had the neccessary motivation to bring this application to an end.

## Technical Specifications

* **Target Platform:** Windows 10 / Windows 11 (x64)
* **Framework:** .NET 8.0
* **Development Environment:** Developed and tested on Windows 11.

## Features

* Real-time pinging logic
* Console output
* Log-saving
* Database History
* Customizable Settings
* User preferences (presets)
* Windows notifications

## Current state & Future plans

While the main functionality is operational, Ping Requester may contain minor bugs. Unit tests have been implemented for the Business Layer only (see: [Business Layer Unit Tests](https://github.com/vitek-14/ping-requester-desktop-dotnet/tree/main/PingRequester.Tests/business)). Feel free to open an issue for any bugs you encounter.

At the moment, I do not plan on active further development unless there is an interest. As the industry shifts, modern web technologies are the way forward; therefore, I plan to invest my future efforts into learning ASP.NET and Blazor.

## Installation
1. Download the **`PingRequesterSetup.msi`** file from Assets from [this link](https://github.com/vitek-14/ping-requester-desktop-dotnet/releases/tag/v0.1.0).
2. Run the installer and follow the on-screen instructions.
3. *Note: Ensure you have the **.NET 8.0 Runtime** installed on your system.*

*How to uninstall?* 

To uninstall the application run the **`PingRequesterSetup.msi`** file once again and select the *Remove* option.

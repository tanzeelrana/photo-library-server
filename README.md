# Photo Album

This simple console application allows users to fetch photos from a JSON web service based on the album ID.

## Dependencies

- .NET SDK: Ensure that you have the .NET SDK installed on your machine. You can download it from [here](https://dotnet.microsoft.com/download).

## Packages Used

- Newtonsoft.Json: This package is used for JSON serialization and deserialization. You can install it using the following command:

    ```
    dotnet add package Newtonsoft.Json
    ```
- NUnit.Framework: This package is used for unit testing. You can install it using the following command:

    ```
    dotnet add package NUnit.Framework
    ```
    

## Instructions

### Build and Run the Application

1. **Clone the Repository**: Clone this repository to your local machine using Git:

    ```
    git clone <repository_url>
    ```

2. **Open in Visual Studio Code**: Open the project folder in Visual Studio Code:

    ```
    cd library
    ```

3. **Build the Application**: In Visual Studio Code terminal, build the application using the .NET CLI:

    ```
    dotnet build
    ```

4. **Run the Application**: Run the application using the .NET CLI:

    ```
    dotnet run
    ```

5. **Enter Album ID**: Follow the prompts to enter the album ID. You can type 'quit' to exit the application.

## Usage

- Enter a valid album ID to fetch photos from the JSON web service.
- Type 'quit' to exit the application.


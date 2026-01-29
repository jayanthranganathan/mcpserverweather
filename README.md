# MCP Server Weather - .NET Weather Service

A .NET 10.0 Model Context Protocol (MCP) server demonstration project that provides weather information and utilities.

## Overview

**mcpdemo** is a .NET-based MCP server that integrates with the weatherstack API to deliver real-time weather data. The project showcases how to build an MCP-compatible service with dependency injection, hosting, and JSON serialization.

## Features

- **Weather API Integration**: Fetches current weather and forecast data from weatherstack
- **MCP Server**: Implements the Model Context Protocol for seamless integration
- **Strongly Typed Models**: Comprehensive C# models matching weather API responses
- **Built with .NET 10**: Latest .NET framework for performance and modern language features

## Project Structure
```text
mcpdemo/
├── Models/
│   ├── WeatherRequest.cs    # Main weather data model
│   ├── Location.cs          # Location details
│   ├── Current.cs           # Current weather details
│   ├── Historical.cs        # Historical weather data
│   └── Hourly.cs            # Hourly forecast data
├── Services/
│   └── WeatherService.cs    # Weather API integration logic
├── Program.cs               # Application entry point and DI configuration
└── mcpdemo.csproj           # Project dependencies and configuration
```

## Dependencies

- **ModelContextProtocol** (0.6.0-preview.1) - MCP framework
- **Microsoft.Extensions.Hosting** (10.0.2) - Host builder and DI
- **System.Text.Json** (10.0.2) - JSON serialization
- **Microsoft.Extensions.AI.Abstractions** (10.1.1) - AI abstractions

## Getting Started

### Prerequisites
- .NET 10.0 SDK or later
- Visual Studio Code or Visual Studio 2022+

### Installation

1. Navigate to the project directory:
```bash
cd mcpdemo/mcpdemo
```

2. Restore packages:
```bash
dotnet restore
```
3. Build the project:
```bash
dotnet build
```
4. Run the application:
```bash
dotnet run
```

## Configuration
The MCP server is configured in mcp.json:

**Type:** stdio
**Command:** dotnet run
**Project:** mcpdemo.csproj

## API Integration
The WeatherService uses the weatherstack API for weather data:

**Base URL:** https://api.weatherstack.com/

**Endpoints:**

/current - Current weather

/forecast - Weather forecast

**Usage**
Query weather data through the MCP interface for specific cities and forecast periods.

**Author**
Jayanth Ranganathan

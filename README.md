# 🌦️ FinalApp – .NET Web API Weather Forecast

This project is a simple ASP.NET Core Web API that returns a 5-day weather forecast. It's containerized using Docker for easy deployment.

---

## 📦 Features

- Minimal .NET 8 Web API
- `WeatherForecastController` returns randomized weather data
- Clean model/view separation
- Dockerfile for containerized deployment

---

## 🛠️ Technologies Used

- [.NET 8](https://dotnet.microsoft.com/en-us/)
- C#
- ASP.NET Core Web API
- Docker

---

## 🚀 Getting Started

### ✅ Prerequisites

- [.NET SDK 8.0+](https://dotnet.microsoft.com/en-us/download)
- [Docker](https://docs.docker.com/get-docker/)

---

## 🧪 Run Locally (Without Docker)

1. **Clone the repo**

   ```bash
   git clone https://github.com/mina14george/FinalApp.git
   cd FinalApp
   ```

2. **Run the app**

   ```bash
   dotnet run --project FinalApp
   ```

3. **Visit**

   ```
   http://localhost:5153/WeatherForecast
   ```

---

## 🐳 Run in Docker

1. **Publish the app**

   ```bash
   dotnet publish FinalApp -c Release -o out
   ```

2. **Build the Docker image**

   ```bash
   docker build -t finalapp .
   ```

3. **Run the container**

   ```bash
   docker run -d -p 5153:5153 finalapp
   ```

4. **Test the API** Visit [http://localhost:5153/WeatherForecast](http://localhost:5153/WeatherForecast)

---

## 📂 Project Structure

```
FinalApp/
├── Controllers/
│   └── WeatherForecastController.cs
├── Models/
│   └── WeatherForecast.cs
├── Program.cs
├── FinalApp.csproj
├── appsettings.json
├── Dockerfile
└── README.md
```

---

## 🧠 Notes on Docker Port Binding

If the container logs show:

```
Now listening on: http://[::]:8080
```

That means the container defaulted to port 8080 because the base image set:

```env
ASPNETCORE_URLS=http://+:8080
```

### ✅ Fix 1: Set Environment Variable in Dockerfile

```dockerfile
ENV ASPNETCORE_URLS=http://+:5153
```

### ✅ Fix 2: Set it at `docker run` time:

```bash
docker run -d -p 5153:5153 -e ASPNETCORE_URLS=http://+:5153 finalapp
```

Also make sure `Program.cs` includes:

```csharp
builder.WebHost.UseUrls("http://0.0.0.0:5153");
```

---

## ✍️ Author

**Mina** – DevOps Engineer\
Feel free to reach out!

---

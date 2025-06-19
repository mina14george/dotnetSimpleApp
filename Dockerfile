FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app

ENV ASPNETCORE_URLS=http://+:5153
COPY FinalApp/out/ .
EXPOSE 5153
ENTRYPOINT ["dotnet", "FinalApp.dll"]


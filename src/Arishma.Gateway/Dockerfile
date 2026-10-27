FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY *.sln ./
COPY src/Arishma.Gateway/Arishma.Gateway.csproj src/Arishma.Gateway/
RUN dotnet restore src/Arishma.Gateway/Arishma.Gateway.csproj
COPY . .
RUN dotnet publish src/Arishma.Gateway/Arishma.Gateway.csproj -c Release -o /app/publish --no-restore
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://*:5000
ENTRYPOINT ["dotnet", "Arishma.Gateway.dll"]

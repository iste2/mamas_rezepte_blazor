# NuGet restore
FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
COPY *.sln .
COPY Shared/*.csproj Shared/
COPY Client/*.csproj Client/
COPY Server/*.csproj Server/
RUN dotnet restore
COPY . .

# build
FROM build AS testing
RUN dotnet build

# publish
FROM build AS publish
RUN dotnet publish -c Release

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS runtime
WORKDIR /app
COPY --from=publish /Server/bin/Release/netcoreapp3.1/publish .
# ENTRYPOINT ["dotnet", "Colors.API.dll"]
# heroku uses the following
CMD ASPNETCORE_URLS=http://*:$PORT dotnet MamasRezepte.Server.dll

# NuGet restore
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY *.sln .
COPY Shared/*.csproj Shared/
COPY Client/*.csproj Client/
COPY Server/*.csproj Server/
RUN dotnet restore
COPY . .

# build
FROM build AS testing
WORKDIR /src/Server
RUN dotnet build

# publish
FROM build AS publish
WORKDIR /src/Server
RUN dotnet publish -c Release -o /src/publish

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
WORKDIR /app
COPY --from=publish /src/publish .
# ENTRYPOINT ["dotnet", "MamasRezepte.Server.dll"]
# heroku uses the following
CMD ASPNETCORE_URLS=http://*:$PORT dotnet MamasRezepte.Server.dll

# Nginx
#FROM nginx:alpine AS final
#WORKDIR /usr/share/nginx/html
#COPY --from=publish /app/publish/MamasRezepte/dist .
#COPY nginx.conf /etc/nginx/nginx.conf

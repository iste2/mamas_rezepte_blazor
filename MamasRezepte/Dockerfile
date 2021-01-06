# Restore
FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /Server
COPY MamasRezepte.Server.csproj .
RUN dotnet restore "MamasRezepte.Server.csproj"
COPY . .

# Build
RUN dotnet build "MamasRezepte.Server.csproj" -c Release -o /app/build

# Publish
FROM build AS publish
RUN dotnet publish "MamasRezepte.Server.csproj" -c Release -o /app/publish

# Nginx
FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/MamasRezepte/dist .
COPY nginx.conf /etc/nginx/nginx.conf

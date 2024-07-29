#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Restaurant/Restaurant.API/Restaurant.API.csproj", "Restaurant/Restaurant.API/"]
COPY ["Restaurant/Restaurant.Application/Restaurant.Application.csproj", "Restaurant/Restaurant.Application/"]
COPY ["Restaurant/Restaurant.Infrastructure/Restaurant.Infrastructure.csproj", "Restaurant/Restaurant.Infrastructure/"]
COPY ["Restaurant/Restaurant.Core/Restaurant.Core.csproj", "Restaurant/Restaurant.Core/"]
RUN dotnet restore "./Restaurant/Restaurant.API/Restaurant.API.csproj"
COPY . .
WORKDIR "/src/Restaurant/Restaurant.API"
RUN dotnet build "./Restaurant.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Restaurant.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Restaurant.API.dll"]
#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app


FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Services/Contact.API/Contact.API.csproj", "Services/Contact.API/"]
COPY ["Services/Contact.Application/Contact.Application.csproj", "Services/Contact.Application/"]
COPY ["Services/Contact.Infrastructure/Contact.Infrastructure.csproj", "Services/Contact.Infrastructure/"]
COPY ["Services/Contact.Core/Contact.Core.csproj", "Services/Contact.Core/"]
RUN dotnet restore "./Services/Contact.API/Contact.API.csproj"
COPY . .
WORKDIR "/src/Services/Contact.API"
RUN dotnet build "./Contact.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Contact.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Contact.API.dll"]
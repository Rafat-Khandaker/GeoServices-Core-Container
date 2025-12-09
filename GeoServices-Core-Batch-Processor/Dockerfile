# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
USER $APP_UID
WORKDIR /app


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["GeoServices-Core-Batch-Processor/GeoServices-Core-Batch-Processor.csproj", "GeoServices-Core-Batch-Processor/"]
RUN dotnet restore "./GeoServices-Core-Batch-Processor/GeoServices-Core-Batch-Processor.csproj"
COPY . .
WORKDIR "/src/GeoServices-Core-Batch-Processor"
RUN dotnet build "./GeoServices-Core-Batch-Processor.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./GeoServices-Core-Batch-Processor.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GeoServices-Core-Batch-Processor.dll"]
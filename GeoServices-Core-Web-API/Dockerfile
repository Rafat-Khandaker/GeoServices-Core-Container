# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER root
WORKDIR /app

RUN apt-get update && apt-get install -y wget && apt-get install -y unzip  && apt-get clean 

RUN wget -O "linux_geo25b_25.2.zip" "https://s-media.nyc.gov/agencies/dcp/assets/files/zip/data-tools/bytes/geosupport/linux_geo25b_25.2.zip"
RUN unzip linux_geo25b_25.2.zip

#ENV LD_DEBUG=libs

#ENV LD_BIN_PATH=app/bin/Debug/net9.0/lib/bin
ENV LD_LIBRARY_PATH=version-25b_25.2/lib
ENV GEOFILES=version-25b_25.2/fls/

#ENV LD_LIBRARY_PATH=app/bin/Debug/net9.0/lib/bin
#ENV GEOFILES=app/bin/Debug/net9.0/lib/fls/

ENV ASPNETCORE_Kestrel__Certificates__Default__Path=Certificate/geoservices-core-web-api.pfx
ENV ASPNETCORE_Kestrel__Certificates__Default__Password=df212dauh109k

EXPOSE 8080
EXPOSE 8081

# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["GeoServices-Core-Web-API/GeoServices-Core-Web-API.csproj", "GeoServices-Core-Web-API/"]
COPY ["GeoServices-Core-Commons/GeoServices-Core-Commons.csproj", "GeoServices-Core-Commons/"]
COPY ["GeoXWrapperLib/GeoXWrapperLib/GeoXWrapperLib.csproj", "GeoXWrapperLib/GeoXWrapperLib/"]
RUN dotnet restore "./GeoServices-Core-Web-API/GeoServices-Core-Web-API.csproj"
COPY . .
WORKDIR "/src/GeoServices-Core-Web-API"
RUN dotnet build "./GeoServices-Core-Web-API.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./GeoServices-Core-Web-API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GeoServices-Core-Web-API.dll"]
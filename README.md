# Sunil-Poojastores

This is a Dotnet Project with version of 3.1.

To Install Dotnet in our Localhost (Ubuntu), follow the below commands:

Install the pacakge:
wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb

Install the .NET SDK:
sudo apt-get update
sudo apt-get install -y apt-transport-https
sudo apt-get update
sudo apt-get install -y dotnet-sdk-3.1

Check Version:
dotnet --version

Get into the directory of the Project:
cd /path/to/your/project/PoojaStores

Use this restore command to restore any Nuget dependies found in project file (In this case PoojaStores.csproj):
dotnet restore

Build the dotnet project:
dotnet build

To run the application in the localhost, use the following command:
dotnet run

To check the application running, go to browser and hit ...
http://localhost:5000 or https://localhost:5001



________________________________________To run the application in a Dockerized__________________________________________
I have given the Dockerfile for this application containing the 3.1 version and build the proj file, pusblish and run the applciation through docker.

DOCKERFILE:
_________________________________________________________________________________________
# Use the ASP.NET Core 3.1 runtime image
FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

# Use the SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["PoojaStores.csproj", "./"]
RUN dotnet restore "PoojaStores.csproj"
COPY . .
RUN dotnet build "PoojaStores.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PoojaStores.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PoojaStores.dll"]

________________________________________________________________________________________

docker build -t poojastores .
docker run -d -p 8080:80 --name myapp poojastores


**Explanation for the Docker file:**

Base Image for Runtime:

dockerfile

# FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
# WORKDIR /app
# EXPOSE 80
> FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base: This line specifies the base image for the final runtime stage of the build. It's using the official ASP.NET Core 3.1 image.
> WORKDIR /app: This sets the working directory inside the container to /app.
> EXPOSE 80: This tells Docker that the container will listen on port 80, the default HTTP port.
Build Stage:

# FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
# WORKDIR /src
# COPY ["PoojaStores.csproj", "./"]
# RUN dotnet restore "PoojaStores.csproj"
# COPY . .
#RUN dotnet build "PoojaStores.csproj" -c Release -o /app/build

> FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build: This line starts the build stage, using the official .NET SDK 3.1 image.
> WORKDIR /src: Sets the working directory to /src.
> COPY ["PoojaStores.csproj", "./"]: Copies the project file into the Docker image.
> RUN dotnet restore "PoojaStores.csproj": Restores any NuGet dependencies (defined in PoojaStores.csproj).
> COPY . .: Copies the rest of the files into the image.
> RUN dotnet build "PoojaStores.csproj" -c Release -o /app/build: Builds the application in Release configuration and outputs it to /app/build.

# FROM build AS publish
# RUN dotnet publish "PoojaStores.csproj" -c Release -o /app/publish
> FROM build AS publish: This continues from the build stage, and its purpose is to publish the application.
> RUN dotnet publish "PoojaStores.csproj" -c Release -o /app/publish: Publishes the application to the /app/publish directory.


# FROM base AS final
# WORKDIR /app
# COPY --from=publish /app/publish .
# ENTRYPOINT ["dotnet", "PoojaStores.dll"]
> FROM base AS final: This starts the final stage, continuing from the base stage (the runtime image).
> WORKDIR /app: Sets the working directory to /app.
> COPY --from=publish /app/publish .: Copies the published application from the publish stage into the final image.
> ENTRYPOINT ["dotnet", "PoojaStores.dll"]: Specifies the entry point of the application, which is how the application will be started.


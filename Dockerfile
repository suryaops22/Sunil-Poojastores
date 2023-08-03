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


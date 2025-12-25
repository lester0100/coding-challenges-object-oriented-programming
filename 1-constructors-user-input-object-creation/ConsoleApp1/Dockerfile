FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy entire repository into the build container
COPY . /src

# Publish this specific project (adjust path if needed)
RUN dotnet publish 1-constructors-user-input-object-creation/ConsoleApp1/constructor.csproj -c Release -o /app

FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build /app ./

ENTRYPOINT ["dotnet", "constructor.dll"]
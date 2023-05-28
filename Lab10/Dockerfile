FROM mcr.microsoft.com/dotnet/sdk:7.0-alpine AS build
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

RUN dotnet add package ClosedXML

COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:7.0-alpine AS runtime
WORKDIR /app
EXPOSE 80

# Set the culture to the invariant culture
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=true

COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "Lab6.dll"]

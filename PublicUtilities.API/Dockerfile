#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["PublicUtilities.API/PublicUtilities.API.csproj", "PublicUtilities.API/"]
COPY ["PublicUtitilities.SQL.Repositories/PublicUtitilities.SQL.Repositories.csproj", "PublicUtitilities.SQL.Repositories/"]
COPY ["PublicUtilities.Services/PublicUtilities.Services.csproj", "PublicUtilities.Services/"]
COPY ["PublicUtitilities.DomainClasses/PublicUtitilities.DomainClasses.csproj", "PublicUtitilities.DomainClasses/"]
COPY ["BuildingBlocks/EventBus.Messages/EventBus.Messages.csproj", "BuildingBlocks/EventBus.Messages/"]
RUN dotnet restore "PublicUtilities.API/PublicUtilities.API.csproj"
COPY . .
WORKDIR "/src/PublicUtilities.API"
RUN dotnet build "PublicUtilities.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PublicUtilities.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PublicUtilities.API.dll"]

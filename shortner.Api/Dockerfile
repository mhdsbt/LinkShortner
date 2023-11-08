FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["shortner.Api/shortner.Api.csproj", "shortner.Api/"]
RUN dotnet restore "shortner.Api/shortner.Api.csproj"
COPY . .
WORKDIR "/src/shortner.Api"
RUN dotnet build "shortner.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "shortner.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "shortner.Api.dll"]

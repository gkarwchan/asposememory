FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["parsefileV10/parsefileV10.csproj", "parsefileV10/"]
RUN dotnet restore "parsefileV10/parsefileV10.csproj"
COPY . .
WORKDIR "/src/parsefileV10"
RUN dotnet build "parsefileV10.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "parsefileV10.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "parsefileV10.dll"]

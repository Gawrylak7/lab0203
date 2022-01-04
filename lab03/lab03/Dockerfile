FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["lab03/lab03.csproj", "lab03/"]
RUN dotnet restore "lab03/lab03.csproj"
COPY . .
WORKDIR "/src/lab03"
RUN dotnet build "lab03.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "lab03.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "lab03.dll"]

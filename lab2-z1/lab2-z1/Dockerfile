FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["lab2-z1/lab2-z1.csproj", "lab2-z1/"]
RUN dotnet restore "lab2-z1/lab2-z1.csproj"
COPY . .
WORKDIR "/src/lab2-z1"
RUN dotnet build "lab2-z1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "lab2-z1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "lab2-z1.dll"]

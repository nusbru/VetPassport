# Etapa 1: Build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

# Copia a solução e restaura as dependências
COPY ./*.sln ./
COPY ./src/VetPassport.API/*.csproj ./src/VetPassport.API/
RUN dotnet restore ./src/VetPassport.API/VetPassport.API.csproj

# Copia o restante do código e faz o build
COPY ./src/VetPassport.API/. ./src/VetPassport.API/
WORKDIR /app/src/VetPassport.API
RUN dotnet publish -c Release -o /publish

# Etapa 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "VetPassport.API.dll"]

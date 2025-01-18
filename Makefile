# Tarefas
.PHONY: all build run test clean

all: build

build:
		dotnet build ./VetPassport.sln

run:
		dotnet run --project ./src/VetPassport.API/VetPassport.API.csproj

test:
		dotnet test --project ./test/VetPassport.API.Tests/VetPassport.API.Tests.csproj

clean:
		dotnet clean ./VetPassport.sln
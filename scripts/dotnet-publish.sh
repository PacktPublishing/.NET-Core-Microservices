cd src
dotnet publish ./Actio.Api -c Release -o ./bin/Docker
dotnet publish ./Actio.Services.Activities -c Release -o ./bin/Docker
dotnet publish ./Actio.Services.Identity -c Release -o ./bin/Docker
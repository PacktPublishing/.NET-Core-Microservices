cd src
docker build -f ./Actio.Api/Dockerfile -t actio.api ./Actio.Api
docker build -f ./Actio.Services.Activities/Dockerfile -t actio.services.activities ./Actio.Services.Activities
docker build -f ./Actio.Services.Identity/Dockerfile -t actio.services.identity ./Actio.Services.Identity
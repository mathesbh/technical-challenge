FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app
#EXPOSE 80

COPY *.sln .
COPY "/Technical.Challenge/Technical.Challenge.csproj" "/Technical.Challenge/"
COPY "/Technical.Challenge.Api/Technical.Challenge.Api.csproj" "/Technical.Challenge.Api/"
COPY "/Technical.Challenge.Domain/Technical.Challenge.Domain.csproj" "/Technical.Challenge.Domain/"
COPY "/Technical.Challenge.Helpers/Technical.Challenge.Helpers.csproj" "/Technical.Challenge.Helpers/"
COPY "/Technical.Challenge.Services/Technical.Challenge.Services.csproj" "/Technical.Challenge.Services/"

RUN dotnet restore "/Technical.Challenge.Api/Technical.Challenge.Api.csproj"

COPY . ./
WORKDIR /app/Technical.Challenge.Api
RUN dotnet publish -c Release -o publish 

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build-env /app/Technical.Challenge.Api/publish ./
#ENTRYPOINT ["dotnet", "Technical.Challenge.Api.dll"]
CMD ASPNETCORE_URLS="http://*:$PORT" dotnet Technical.Challenge.Api.dll


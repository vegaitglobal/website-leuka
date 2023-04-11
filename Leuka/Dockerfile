FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

RUN mkdir uploads

ENV ASPNETCORE_URLS=http://*:5113
ENV WebRootPath "/app/uploads"


FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore

FROM build AS publish
RUN dotnet publish -c Release

RUN cp -R Leuka.Web/wwwroot/ Leuka.Web/bin/Release/net6.0/
RUN cp -R Leuka.Web/Views/ Leuka.Web/bin/Release/net6.0/

FROM base AS final
WORKDIR /app
COPY --from=publish /src/Leuka.Web/bin/Release/net6.0 .

EXPOSE 5113
ENTRYPOINT ["dotnet", "Leuka.Web.dll"]

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

RUN dotnet tool install -g Microsoft.Web.LibraryManager.Cli
RUN ln -s ~/.dotnet/tools/libman /usr/local/bin/libman

WORKDIR /src
COPY ["src/Finac.Web.Mvc/Finac.Web.Mvc.csproj", "src/Finac.Web.Mvc/"]
COPY ["src/Finac.Web.Core/Finac.Web.Core.csproj", "src/Finac.Web.Core/"]
COPY ["src/Finac.Application/Finac.Application.csproj", "src/Finac.Application/"]
COPY ["src/Finac.Core/Finac.Core.csproj", "src/Finac.Core/"]
COPY ["src/Finac.EntityFrameworkCore/Finac.EntityFrameworkCore.csproj", "src/Finac.EntityFrameworkCore/"]
WORKDIR "/src/src/Finac.Web.Mvc"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Finac.Web.Mvc", "src/Finac.Web.Mvc"]
COPY ["src/Finac.Web.Core", "src/Finac.Web.Core"]
COPY ["src/Finac.Application", "src/Finac.Application"]
COPY ["src/Finac.Core", "src/Finac.Core"]
COPY ["src/Finac.EntityFrameworkCore", "src/Finac.EntityFrameworkCore"]
WORKDIR "/src/src/Finac.Web.Mvc"
RUN libman restore
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Finac.Web.Mvc.dll"]

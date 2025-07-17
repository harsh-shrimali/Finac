FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/Finac.Web.Host/Finac.Web.Host.csproj", "src/Finac.Web.Host/"]
COPY ["src/Finac.Web.Core/Finac.Web.Core.csproj", "src/Finac.Web.Core/"]
COPY ["src/Finac.Application/Finac.Application.csproj", "src/Finac.Application/"]
COPY ["src/Finac.Core/Finac.Core.csproj", "src/Finac.Core/"]
COPY ["src/Finac.EntityFrameworkCore/Finac.EntityFrameworkCore.csproj", "src/Finac.EntityFrameworkCore/"]
WORKDIR "/src/src/Finac.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Finac.Web.Host", "src/Finac.Web.Host"]
COPY ["src/Finac.Web.Core", "src/Finac.Web.Core"]
COPY ["src/Finac.Application", "src/Finac.Application"]
COPY ["src/Finac.Core", "src/Finac.Core"]
COPY ["src/Finac.EntityFrameworkCore", "src/Finac.EntityFrameworkCore"]
WORKDIR "/src/src/Finac.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Finac.Web.Host.dll"]

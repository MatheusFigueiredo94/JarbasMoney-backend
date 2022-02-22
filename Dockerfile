#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["JarbasMoney.Api/JarbasMoney.Api.csproj", "JarbasMoney.Api/"]
COPY ["JarbasMoney.Domain/JarbasMoney.Domain.csproj", "JarbasMoney.Domain/"]
COPY ["JarbasMoney.Shared/JarbasMoney.Shared.csproj", "JarbasMoney.Shared/"]
COPY ["JarbasMoney.Infra/JarbasMoney.Infra.csproj", "JarbasMoney.Infra/"]
RUN dotnet restore "JarbasMoney.Api/JarbasMoney.Api.csproj"
COPY . .
WORKDIR "/src/JarbasMoney.Api"
RUN dotnet build "JarbasMoney.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "JarbasMoney.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet JarbasMoney.dll
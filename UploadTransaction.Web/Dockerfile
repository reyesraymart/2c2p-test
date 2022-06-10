#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["UploadTransaction.Web/UploadTransaction.Web.csproj", "UploadTransaction.Web/"]
COPY ["UploadTransaction.DataLayer/UploadTransaction.DataLayer.csproj", "UploadTransaction.DataLayer/"]
COPY ["UploadTransaction.Core/UploadTransaction.Core.csproj", "UploadTransaction.Core/"]
COPY ["UploadTransaction.Importer/UploadTransaction.Importer.csproj", "UploadTransaction.Importer/"]
RUN dotnet restore "UploadTransaction.Web/UploadTransaction.Web.csproj"
COPY . .
WORKDIR "/src/UploadTransaction.Web"
RUN dotnet build "UploadTransaction.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "UploadTransaction.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UploadTransaction.Web.dll"]
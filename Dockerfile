FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 57583

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY DeliveryService.sln ./
COPY DeliveryService.Api/DeliveryService.Api.csproj DeliveryService.Api/
COPY DeliveryService.Application/DeliveryService.Application.csproj DeliveryService.Application/
COPY DeliveryService.Data.SQL/DeliveryService.Data.SQL.csproj DeliveryService.Data.SQL/
RUN dotnet restore -nowarn:msb3202,nu1503
COPY . .
WORKDIR /src/DeliveryService.Api
RUN dotnet build -o /app

FROM build AS publish
RUN dotnet publish -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DeliveryService.Api.dll"]

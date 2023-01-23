FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app
EXPOSE 80
COPY *.csproj ./
RUN dotnet restore "Auto.SignalR.csproj"
COPY . ./
RUN dotnet publish "Auto.SignalR.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Auto.SignalR.dll"]

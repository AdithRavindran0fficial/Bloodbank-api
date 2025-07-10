FROM mcr.microsoft.com/dotnet/sdk:8.0 AS Build
WORKDIR /App
COPY ./BloodDonation/*.csproj ./BloodDonation
COPY ./BloodDonation/ ./BloodDonation/

WORKDIR /App/BloodDonation
RUN dotnet restore
RUN dotnet publish -c Release -o /App/out


FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS Run
WORKDIR /App
COPY  --from=Build /App/out .
ENTRYPOINT [ "dotnet","BloodDonation.dll" ]

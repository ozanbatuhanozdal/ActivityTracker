DEPENDENCİES
.NET > 5.0
POSTGRE > 13.1



SAMPLE APPSETTİNGS.JSON

{
  "ConnectionStrings": {
    "ActivityTrackerDB": "Server=localhost;Port=5432;Username=user; Password=root;Database=ActivityTrackerDB;Integrated Security=true;Pooling=true;"
  },

  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*"
}

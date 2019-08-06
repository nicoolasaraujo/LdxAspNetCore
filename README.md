#Instalação Swagger
dotnet add package Swashbuckle.AspNetCore


#Instação Serilog
dotnet add  package Serilog.AspNetCore
dotnet add  package Serilog.Sinks.Async
dotnet add  package Serilog.Sinks.Console
dotnet add  package Serilog.Sinks.File
dotnet add  package Serilog.Settings.Configuration
dotnet add  package Serilog.Formatting.Compact
dotnet add  package Serilog.Enrichers.Environment
dotnet add  package Serilog.Enrichers.Thread

#Executar Projeto

##Padrão (Pasta do projeto)
dotnet run

##Variavel de ambiente
dotnet run --environment="Production"
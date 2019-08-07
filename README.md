# Instalação Swagger
dotnet add package Swashbuckle.AspNetCore


# Instação Serilog
dotnet add  package Serilog.AspNetCore
dotnet add  package Serilog.Sinks.Async
dotnet add  package Serilog.Sinks.Console
dotnet add  package Serilog.Sinks.File
dotnet add  package Serilog.Settings.Configuration
dotnet add  package Serilog.Formatting.Compact
dotnet add  package Serilog.Enrichers.Environment
dotnet add  package Serilog.Enrichers.Thread

# Executar Projeto

## Padrão (Pasta do projeto)
dotnet run

## Variavel de ambiente
dotnet run --environment="Production"


# Apresentação
https://docs.google.com/presentation/d/1D-89tn9eZe1rplcz1K7v0Q5wiVqL6v_tTcwQ3ddoFv0/edit?usp=sharing


# Servidor Syslog para testes
https://gist.github.com/marcelom/4218010
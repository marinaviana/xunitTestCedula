dotnet new console -n "MeuPrograma" 
dotnet new xunit -n "caixaEletronico"
dotnet build 
dotnet run
dotnet new nunit
dotnet new nunit --force  
dotnet add package Moq  
dotnet add package Moq  
dotnet test
dotnet add package NodaTime 
dotnet new NodaTime --force

dotnet --list-runtimes 
dotnet --list-sdks
dotnet --version
dotnet restore --interactive 

https://learn.microsoft.com/pt-br/dotnet/core/install/linux-ubuntu-2004

dotnet add package NSubstitute --version 5.0.0 [https://www.nuget.org/packages/NSubstitute]

dotnet add package Moq --version 4.18.4  [https://www.nuget.org/packages/Moq/]

dotnet add package Microsoft.Extensions.DependencyInjection --version 8.0.0-preview.4.23259.5 [https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection/8.0.0-preview.4.23259.5]

dotnet add package FluentAssertions --version 6.11.0 [https://www.nuget.org/packages/FluentAssertions/]

https://www.codemag.com/Article/2009101/Interactive-Unit-Testing-with-.NET-Core-and-VS-Code

"File" (Arquivo) > "Preferences" (prefereência) > "Settings" (configurações) > "Extenções" > "Test Project Path" > "*Test.cs".

dotnet add package Microsoft.AspNetCore.App --version 2.2.8 [https://www.nuget.org/packages/Microsoft.AspNetCore.App/]
dotnet add package Microsoft.AspNetCore.Mvc.Testing --version 7.0.5 [https://www.nuget.org/packages/Microsoft.AspNetCore.Mvc.Testing/]
# Create project

1) dotnet new sln -o . 

2) dotnet new classlib -o CsharpSolid

3) dotnet sln add ./CsharpSolid/CsharpSolid.csproj

4) dotnet new xunit -o CsharpSolid.Tests

5) dotnet sln add ./CsharpSolid.Tests/CsharpSolid.Tests.csproj

6) dotnet add ./CsharpSolid.Tests/CsharpSolid.Tests.csproj reference ./CsharpSolid/CsharpSolid.csproj

If you met this problem and run the asp.net core with CLI tool, you may solve it by adding
<DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="2.0.0" />
into xx.csproj file, and
dotnet restore
. Then you can use dotnet ef command. 

@echo off

dotnet restore

dotnet build --no-restore -c Release

dotnet nuget push Panosen.Resource.Npm\bin\Release\Panosen.Resource.Npm.*.nupkg -s https://package.savory.cn/v3/index.json --skip-duplicate

move /Y Panosen.Resource.Npm\bin\Release\Panosen.Resource.Npm.*.nupkg D:\LocalSavoryNuget\

pause
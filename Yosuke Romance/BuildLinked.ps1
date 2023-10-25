# Set Working Directory
Split-Path $MyInvocation.MyCommand.Path | Push-Location
[Environment]::CurrentDirectory = $PWD

Remove-Item "$env:RELOADEDIIMODS/Yosuke_Romance/*" -Force -Recurse
dotnet publish "./Yosuke_Romance.csproj" -c Release -o "$env:RELOADEDIIMODS/Yosuke_Romance" /p:OutputPath="./bin/Release" /p:ReloadedILLink="true"

# Restore Working Directory
Pop-Location
@echo off
dotnet build "%~dp0src" -c Release --nologo
pause

@ECHO off
WHERE tar.exe >nul 2>nul
IF %ERRORLEVEL% NEQ 0 ECHO "tar.exe" not found, please create the zip file manually! && EXIT 1
tar.exe -cf "%1.zip" "Info.json" "%1.dll"

@echo off
title HWID-VIEWER
color 01
cls
if exist "node_modules" (
:a
node main.js
pause
goto a
)else (
echo MODULE INSTALLATION
npm i
pause
)
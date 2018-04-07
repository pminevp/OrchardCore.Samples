# Orchard Core Templates

Orchard Core Templates is a solution for theme and module developers. It is also a repository for documenting different types of ways to develop modules and themes on Orchard Core CMS.

    Orchard Core Templates uses Orchard Core Nuget packages instead of using the Orchard Core source code directly. We are doing this mainly because we think that we should never need to modify Orchard Core directly in a website production context; but only extend it per need. By doing so we increase productivity by getting faster compilation time since we should only need to compile what we are working on. Also, it is way easier to target a specific version of Orchard and thus easier to manage than using full source code and handling merge issues.

Orchard Core Templates also includes dotnet new templates configurations for creating new themes and modules from command shell.

## HOW TO

## Create a new theme

1. From Visual Studio

    In order to install Orchard Core into an existing web project, you'll first need an existing web project. Orchard Core runs on .Net Core 2.0, so you'll need to make sure you have it installed before you continue.

    First, fire up Visual Studio, and create a new ASP.NET Core Web Application:

2. From Command Shell

## Create a new module

1. From Visual Studio

2. From Command Shell
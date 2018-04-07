# Orchard Core Templates

Orchard Core Templates is a solution for theme and module developers. It is also a repository for documenting different types of ways to develop modules and themes on Orchard Core CMS.

Orchard Core Templates uses Orchard Core Nuget packages instead of using the Orchard Core source code directly. We are doing this mainly because we think that we should never need to modify Orchard Core directly in a website production context; but only extend it per need. By doing so we increase productivity by getting faster compilation time since we should only need to compile what we are working on. Also, it is way easier to target a specific version of Orchard and thus easier to manage than using full source code and handling merge issues.

Orchard Core Templates also includes dotnet new templates configurations for creating new themes and modules from command shell.

## HOW TO

Orchard Core runs on .Net Core 2.0, so you'll need to make sure you have it installed before you continue.

https://www.microsoft.com/net/download/all

## Create a new theme

1. From Visual Studio

Fire up Visual Studio, open OrchardCore.Templates.sln, select OrchardCore.Modules folder, right click and select "add --> new project" and create a new .NET Core Class Library:

![image](https://user-images.githubusercontent.com/3228637/38450038-dd03c31c-39e4-11e8-9929-eafc6897fe00.png)

Don't forget to select the proper folder location which should be : 
\OrchardCore.Templates\OrchardCore.Modules\

Also, we strongly suggest that you name your modules like this : MyModule.OrchardCore if you consider sharing this module through Nuget afterward ; Since OrchardCore.Something is already taken by Orchard Core Nuget feed. Alternatively if you want to name your modules OrchardCore.Something 



2. From Command Shell

## Create a new module

1. From Visual Studio

2. From Command Shell


## Commands

dotnet new -i "C:\...\OrchardCore.Templates\src\OrchardCore.Cms.Web

dotnet new -i "C:\...\Projects\OrchardCore.Templates\src\Modules\TemplateModule.OrchardCore"

dotnet new -i "C:\...\OrchardCore.Templates\src\Themes\TemplateTheme.OrchardCore"

et après, dans un répertoire, une de ces commandes :

dotnet new ocweb

dotnet new ocmodule -n "Module.OrchardCore"

dotnet new octheme -n "Theme.OrchardCore"

dotnet new --debug:reinit

dotnet new ocmodule -n "Module.OrchardCore" -PartName "TestPart"

dotnet new ocweb -AddNLog true

dotnet new ocmodule -n "Module.OrchardCore" -PartName "TestPart" -AddPart true

https://github.com/dotnet/dotnet-template-samples
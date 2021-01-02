<h1 align="center">

TrelloClone

</h1>

<div align="center">

![visitors](https://vistr.dev/badge?repo=johnmcraig.TrelloClone)
![stars](https://img.shields.io/github/stars/johnmcraig/TrelloClone?style=flat-square&cacheSeconds=604800)
![last commit](https://img.shields.io/github/last-commit/johnmcraig/TrelloClone?style=flat-square&cacheSeconds=86400)
![pull requests](https://img.shields.io/github/issues-pr/johnmcraig/TrelloClone?color=0088ff)
![forks](https://img.shields.io/github/forks/johnmcraig/TrelloClone?color=0088ff)

</div>

> A Kanban board using ASP.Net Core and Materialize CSS

## Demo

A demo of the application can be found running at: [KanbanDo](https://kanbando.azurewebsites.net/)

## Scope

This project was created for the sole purpose of creating a Kanban board similar to Trello using ASP.Net Core and pairing it with Materialize CSS framework.

### Function

This web application allows the creation of new categories as main boards. Within each board are category columns that separate a list of cards.

Create your own boards by submitting a query in the `Add Board` form. Then add a few cards, which will then add three default columns named: "Todo, Doing, and Done". Move or drag the cards into their respective columns using jQuery's `draggable()` method from the Drag & Drop JavaScript library.

## Software Stack and Tools

The application was built using the following:

- ASP.Net Core 3.1
- jQuery & Ajax for dragging Cards
- Entity Framework Core as the ORM
- Materialize CSS v1.0

## Additional Packages

- SQLite for development

## Installation

- `git clone` the repository or download a .zip file using the download button.
- In the project folder, run `dotnet restore` to install necessary NuGet packages and build runtime.
- Then either use `dotnet run` in the terminal/command line or in Visual Studio with `Ctrl + F5` to build and run the project.
- Navigate to: `https://localhost:5001` or if executed by Visual Studio to `https://localhost:4438` to see the project running.

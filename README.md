# Star Wars Characters

A small ASP.NET Core MVC app that lists Star Wars characters from the public [SWAPI](https://swapi.dev/) API, with page-by-page navigation.

## What it does

- Fetches characters from `https://swapi.dev/api/people/?page={n}`
- Shows each character as a card
- Opens a details popup on click with height, mass, birth year and the number of films they appear in
- Lets you move between result pages

## How it's built

| Layer | What's used |
| --- | --- |
| Framework | ASP.NET Core MVC (.NET 6) |
| HTTP calls | Typed `HttpClient` registered with `AddHttpClient<StarWarsService>()` |
| JSON | `System.Net.Http.Json` (`GetFromJsonAsync`) |
| Views | Razor (`.cshtml`) |

```
StarWars/
├── Controllers/
│   └── CharactersController.cs   # loads a page of characters
├── Services/
│   └── StarWarsService.cs        # calls the SWAPI API
├── Models/
│   └── Character.cs              # Character and CharacterResponse
└── Views/Characters/Index.cshtml # character list and paging
```

The controller gets `StarWarsService` through dependency injection, so the API call stays out of the controller.

## Run it locally

You need the [.NET 6 SDK](https://dotnet.microsoft.com/download) or later.

```bash
git clone https://github.com/VidhiMakwana13/StarWars.git
cd StarWars
dotnet run
```

Then open the URL shown in the terminal (for example `https://localhost:5001`).

## Author

**Vidhi Makwana**, Full Stack Developer (.NET & React) · [LinkedIn](https://www.linkedin.com/in/vidhi-makwana-9a031b27a) · [GitHub](https://github.com/VidhiMakwana13)

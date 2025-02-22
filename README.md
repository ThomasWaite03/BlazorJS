# BlazorJS
BlazorJS is a library that enables Blazor developers to interact with the Web APIs without having to write JavaScript. It leverages JavaScript interop to provide Web API access through C#.

## Features
✅ **C# Wrappers for JavaScript APIs**  
✅ **Encapsulates JavaScript Calls** - No need to write JS manually  
✅ **Simplifies JavaScript Interop** - Use familiar C# syntax  

## Setup
In your `Program.cs`, register the library’s services by adding the following line:
```csharp
builder.Services.AddBlazorJS();
```

## Usage
### Console API Example
```csharp
@using BlazorJS;

@inject IJSConsole _console

@code {
  protected override async Task OnInitializedAsync()
  {
    // Log to the browser console
    await _console.LogAsync("Hello world!");

    // Log an error message
    await _console.ErrorAsync("This is an error!");
  }
}
```

### Local Storage Example
```csharp
@using BlazorJS;

@inject ILocalStorage _localStorage

@code {
  protected override async Task OnInitializedAsync()
  {
    // Save a key/value pair to the local storage
    await _localStorage.SetAsync("myKey", "myValue");

    // Get the value from local storage using the key
    var myValue = await _localStorage.GetAsync("myKey");
  }
}
```

### Session Storage Example
```csharp
@using BlazorJS;

@inject ISessionStorage _sessionStorage

@code {
  protected override async Task OnInitializedAsync()
  {
    // Save a key/value pair to the session storage
    await _sessionStorage.SetAsync("keyToRemove", "valueToRemove");

    // Remove the value from the session storage
    await _sessionStorage.RemoveAsync("keyToRemove");
  }
}
```

## Contributing
Contributions are encouraged and appreciated! If you'd like to contribute, please follow these steps:  

1. **Find an Issue or Create One**  
   - Check existing issues and pick one to work on.  
   - If your change is significant and there's no issue for it, please create one before opening a pull request.  

2. **Create a Branch**  
   - If you're working on an issue, name your branch after it (e.g., `issue-42-fix-logging`).  
   - Otherwise, use a descriptive name (e.g., `feature-new-console-method`).  

3. **Make Your Changes**  
   - Follow the project’s coding style.  
   - Ensure everything works as expected.  

4. **Open a Pull Request (PR)**  
   - Push your branch and open a PR.  
   - Link the PR to the issue if applicable.  
   - Provide a clear description of your changes.  

Even small contributions, like improving documentation, are welcome! 🚀 

## License
This project is licensed under the MIT License. See [LICENSE](LICENSE) for details.

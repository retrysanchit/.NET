[![Hits](https://hits.sh/github.com/retrysanchit/.NET.svg?label=.NET&color=b511cc&logo=csharp)](https://hits.sh/github.com/retrysanchit/.NET/)

# .NET
.NET simplifies development by combining batteries-included tooling, streamlined project setup, and strong defaults in a single ecosystem.

# .NET CLI — Quick Reference

The .NET CLI is used to create, build, run, test, and publish .NET applications.

**Syntax:**

bash

```bash
dotnet <command> [arguments] [options]
```

## 1\. Project Management

| Command | Description |
| --- | --- |
| `dotnet new console -n MyApp` | Create console project |
| `dotnet new classlib -n MyLib` | Create class library |
| `dotnet new webapi -n MyApi` | Create Web API project |
| `dotnet sln add MyApp/MyApp.csproj` | Add project to solution |
| `dotnet sln list` | List solution projects |
| `dotnet sln remove MyApp/MyApp.csproj` | Remove project from solution |

## 2\. Build & Execution

| Command | Description |
| --- | --- |
| `dotnet build` | Compile project |
| `dotnet build -c Release` | Build in Release mode |
| `dotnet run` | Build and execute |
| `dotnet run --no-build` | Run without building |
| `dotnet clean` | Remove build outputs (`bin/`, `obj/`) |
| `dotnet watch run` | Watch files and rerun on changes |

**Notes:**

- `build`: Compile and check errors without executing.
- `run`: Builds if necessary, then executes.
- `clean`: Removes generated build outputs.
- `Release`: Optimized build configuration; `Debug` is the default.

## 3\. Dependencies & NuGet

| Command | Description |
| --- | --- |
| `dotnet restore` | Restore NuGet dependencies |
| `dotnet add package PackageName` | Add NuGet package |
| `dotnet add package PackageName --version 1.0.0` | Add specific version |
| `dotnet remove package PackageName` | Remove package |
| `dotnet list package` | List installed packages |
| `dotnet add reference ../MyLib/MyLib.csproj` | Add project reference |

Restore usually happens automatically during build/run.

## 4\. Testing & Publishing

| Command | Description |
| --- | --- |
| `dotnet test` | Run tests |
| `dotnet publish -c Release` | Prepare application for deployment |
| `dotnet publish -c Release -o ./publish` | Publish to specified directory |
| `dotnet pack -c Release` | Create NuGet package |

## 5\. Utilities

| Command | Description |
| --- | --- |
| `dotnet format` | Format source code |
| `dotnet format --verify-no-changes` | Check formatting |
| `dotnet --version` | Show SDK version |
| `dotnet --info` | Show environment information |
| `dotnet --list-sdks` | List installed SDKs |
| `dotnet --list-runtimes` | List installed runtimes |
| `dotnet sdk check` | Check SDK updates |
| `dotnet --help` | General CLI help |

## 6\. Command-Line Arguments (C#)

Arguments are received through `string[] args` in the application entry point.

**Program.cs**

csharp

```csharp
foreach (string arg in args)
{
    Console.WriteLine(arg);
}
```

**Run:**

bash

```bash
dotnet run -- John 25 Nepal
```

**Output:**

text

```text
John
25
Nepal
```

Access individual arguments:

csharp

```csharp
string name = args[0];
string age = args[1];
```

Check argument count before accessing:

csharp

```csharp
if (args.Length >= 2)
{
    Console.WriteLine($"Name: {args[0]}, Age: {args[1]}");
}
```

### Understanding `--`

Separates .NET CLI options from application arguments.

bash

```bash
dotnet run -c Release -- John 25
```

- `-c Release`: .NET CLI argument.
- `John 25`: Application arguments.

## 7\. Useful CLI Help

bash

```bash
dotnet --help
dotnet <command> --help
```

Examples:

bash

```bash
dotnet new --help
dotnet run --help
dotnet publish --help
```

**Everyday workflow:**

bash

```bash
dotnet new console -n MyApp
cd MyApp
code .
dotnet run
dotnet build
```

**Official documentation:** [https://learn.microsoft.com/en-us/dotnet/core/tools/](<https://learn.microsoft.com/en-us/dotnet/core/tools/>)
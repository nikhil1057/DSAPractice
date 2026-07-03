# Practice

DSA and System Design practice workspace.

## Structure

```
practice/
├── practice.code-workspace    ← Open this in VS Code
├── dsa-python/                ← Python DSA (Pylance + type checking)
├── dsa-csharp/                ← C# DSA (dotnet 8, C# Dev Kit)
└── system-design/             ← (future)
```

## Getting Started

1. Open `practice.code-workspace` in VS Code
2. Install recommended extensions when prompted
3. Start solving problems in the respective folders

## Adding a New Project

Add a new entry to `practice.code-workspace`:

```json
{ "path": "system-design", "name": "System Design" }
```

## IDE Features

- **Python**: Pylance IntelliSense, type checking, auto-import, Black formatter
- **C#**: C# Dev Kit, Roslyn analyzers, IntelliSense, format on save

  Created: /Users/nikhil.tiwari/CodeRepo/practice/
  
  practice/
  ├── practice.code-workspace    ← Open this in VS Code for the full workspace
  ├── README.md
  ├── dsa-python/
  │   ├── main.py                ← Sample Two Sum solution
  │   └── .vscode/
  │       ├── settings.json      ← Pylance, type checking, format on save
  │       └── extensions.json    ← Recommends Python + Pylance + Black
  └── dsa-csharp/
      ├── Program.cs             ← Sample Two Sum solution
      ├── DsaCsharp.csproj       ← .NET 8 console app
      └── .vscode/
          ├── settings.json      ← Roslyn analyzers, format on save
          └── extensions.json    ← Recommends C# Dev Kit
  
  To get Visual Studio-like IDE support:
  
  1. Open practice.code-workspace in VS Code
  2. Install the recommended extensions when prompted (Pylance for Python, C# Dev Kit for C#)
  3. You'll get IntelliSense, error squiggles, auto-imports, and format-on-save in both languages
  
  For future System Design projects, just create a new folder (e.g., practice/system-design/) and add it to the workspace file:
  
  { "path": "system-design", "name": "System Design" }
────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────
   
  Here are all the commands to run/use these projects:
  
  Python DSA:
  
  # Run a solution
  cd /Users/nikhil.tiwari/CodeRepo/practice/dsa-python
  python3 main.py
  
  # Create a new solution file
  touch arrays/two_pointer.py
  
  C# DSA:
  
  # Run the project
  cd /Users/nikhil.tiwari/CodeRepo/practice/dsa-csharp
  dotnet run
  
  # Build (check for errors without running)
  dotnet build
  
  Open workspace in VS Code:
  
  code /Users/nikhil.tiwari/CodeRepo/practice/practice.code-workspace
  
  Install recommended extensions (if not prompted automatically):
  
  # Python
  code --install-extension ms-python.python
  code --install-extension ms-python.vscode-pylance
  code --install-extension ms-python.black-formatter
  
  # C#
  code --install-extension ms-dotnettools.csdevkit
  code --install-extension ms-dotnettools.csharp
  
  Add a new System Design project later:
  
  # Example: C# System Design project
  cd /Users/nikhil.tiwari/CodeRepo/practice
  mkdir system-design
  cd system-design
  dotnet new console --name SystemDesign --output .
  
  # Or Python-based
  mkdir -p system-design-py
  
  Then add it to practice.code-workspace:
  
  { "path": "system-design", "name": "System Design" }
# Directory.Build.props

## Advantages

- Centralized location for package dependencies
- Same version variable can be used for multiple packages

## Disadvantages

- Limited support by both Visual Studio and Rider
  - When adding or removing a package will only act in the csproj files
  - When updating a package, will modify csproj files but not the Directory.Build.props
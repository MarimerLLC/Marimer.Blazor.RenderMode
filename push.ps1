param(
    [Parameter(Mandatory=$True, Position=0, ValueFromPipeline=$false)]
    [System.String]
    $apiKey
)

dotnet nuget push .\Marimer.Blazor.RenderMode\bin\Release\Marimer.Blazor.RenderMode.1.0.2.nupkg --source https://api.nuget.org/v3/index.json --api-key $apiKey
dotnet nuget push .\Marimer.Blazor.RenderMode.WebAssembly\bin\Release\Marimer.Blazor.RenderMode.WebAssembly.1.0.2.nupkg --source https://api.nuget.org/v3/index.json --api-key $apiKey

[![](https://img.shields.io/nuget/v/soenneker.netlify.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.netlify.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.netlify.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.netlify.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.netlify.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.netlify.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.netlify.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.netlify.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Netlify.OpenApiClient

Typed request builders and models for calling the Netlify API from .NET.

## Installation

```bash
dotnet add package Soenneker.Netlify.OpenApiClient
```

## Usage

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Netlify.OpenApiClient;

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", accessToken);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient);

var client = new NetlifyOpenApiClient(adapter);
var user = await client.User.GetAsync(cancellationToken: cancellationToken);
```

The generated client defaults to `https://api.netlify.com/api/v1`. Set `adapter.BaseUrl` before constructing `NetlifyOpenApiClient` to use another endpoint.

For application registration, configuration-based credentials, and managed client reuse, use [`Soenneker.Netlify.OpenApiClientUtil`](https://github.com/soenneker/soenneker.netlify.openapiclientutil).

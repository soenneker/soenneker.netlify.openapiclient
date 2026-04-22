using Soenneker.Tests.HostedUnit;

namespace Soenneker.Netlify.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class NetlifyOpenApiClientTests : HostedUnitTest
{
    public NetlifyOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}

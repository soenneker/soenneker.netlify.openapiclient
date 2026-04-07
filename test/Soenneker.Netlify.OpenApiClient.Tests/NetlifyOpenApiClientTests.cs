using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Netlify.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class NetlifyOpenApiClientTests : FixturedUnitTest
{
    public NetlifyOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Triple.Web.Api.Tests.Acceptance.Broker
{
    [CollectionDefinition(nameof(ApiTestCollection))]
    public class ApiTestCollection:ICollectionFixture<TripleSApiBroker>
    {
    }
}

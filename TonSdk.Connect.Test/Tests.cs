using System;
using NUnit.Framework;

namespace TonSdk.Connect.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            // Create a TonConnectOptions object with the manifest URL
            TonConnectOptions options = new TonConnectOptions()
            {
                ManifestUrl = "https://dedust.io/tonconnect-manifest.json"
            };
            // Initialize TonConnect with the specified options
            TonConnect tonConnect = new(options);
        }
    }
}
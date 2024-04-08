namespace TonSdk.Connect.Tests;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        // Create a TonConnectOptions object with the manifest URL
        TonConnectOptions options = new TonConnectOptions()
        {
            ManifestUrl = "https://nonogram-us.oss-us-east-1.aliyuncs.com/meta-merge/test-tonconnect-manifest.json"
        };
        // Initialize TonConnect with the specified options
        TonConnect tonConnect = new(options);
        // Get wallet configurations
        WalletConfig[] walletsConfig = tonConnect.GetWallets();
        // Set event handlers for status changes and errors
        tonConnect.OnStatusChange(OnStatusChange, OnErrorChange);
        
// Connect to a wallet and await the result
        string result = await tonConnect.Connect(walletsConfig[1]);

// Print the connection result
        Console.WriteLine("Connect link: " + result);
    }

// Method called when the wallet status changes
    void OnStatusChange(Wallet wallet)
    {
        Console.WriteLine("Wallet connected. Address: " + wallet.Account.Address + ". Platform: " + wallet.Device.Platform + "," + wallet.Device.AppName + "," + wallet.Device.AppVersion);
    }

// Method called when errors occur
    void OnErrorChange(string wallet)
    {
        Console.WriteLine(wallet);
    }

}
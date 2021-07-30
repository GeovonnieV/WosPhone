public class Galaxy : Phone, IRingable
{
    string VersionNumber;
    int BatteryPercentage;
    string Carrier;
    public string RingTone;
    public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone)
        : base(versionNumber, batteryPercentage, carrier, ringTone)
    {
        RingTone = ringTone;
        VersionNumber = versionNumber;
        BatteryPercentage = batteryPercentage;
        Carrier = carrier;

    }
    public string Ring()
    {
        // your code here

        return RingTone;
    }

    public string Unlock()
    {
        // your code here

        return ($"Galaxy {VersionNumber} unlocked with finger");
    }
    public override void DisplayInfo()
    {
        // your code here            
        System.Console.WriteLine("#############");
        System.Console.WriteLine($"Galaxy {VersionNumber}");
        System.Console.WriteLine($"Battery %: {BatteryPercentage}");
        System.Console.WriteLine($"Carrier: {Carrier}");
        System.Console.WriteLine($"Ringtone: {RingTone}");
        System.Console.WriteLine("#############");
    }
}

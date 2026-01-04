using UnityEngine;
#if !PLATFORM_WEBGL
using System.Net.NetworkInformation;
#endif

public static class MacAddress
{
    public static string Get()
    {
        string macAddress = "dummy_data_this_is_mac_address";
        int count = 0;
#if !PLATFORM_WEBGL
        foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
        {
            if(5 < count)
            {
                break;
            }
            if (nic.OperationalStatus == OperationalStatus.Up)
            {
                string tempMacAddress = nic.GetPhysicalAddress().ToString();
                if (!string.IsNullOrEmpty(tempMacAddress))
                {
                    macAddress += tempMacAddress;
                    //Debug.Log($"macAddress{count} : {macAddress}");
                    count++;
                }
            }
        }
#endif

        return macAddress;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetFwTypeLib;


namespace OverwatchServerSelector
{
    public class ServerSelector
    {
        const string guidFWPolicy2 = "{E2B3C97F-6AE1-41AC-817A-F6F92166D7DD}";
        const string guidRWRule = "{2C5BC43E-3369-4C33-AB0C-BE9469677AF4}";

        //IP ranges for the servers.
        private string menaIpRanges = "157.175.0.0-157.175.255.255,15.185.0.0-15.185.255.255,15.184.0.0-15.184.255.255";
        private string eu1IpRanges = "5.42.184.0-5.42.191.255,5.42.168.0-5.42.175.255";
        private string eu2IpRanges = "35.198.64.0-35.198.191.255,34.107.0.0-34.107.127.255,35.195.0.0-35.195.255.255,35.246.0.0-35.246.255.255,35.228.0.0-35.228.255.255,34.89.128.0-34.89.255.255,35.242.128.0-35.242.255.255,34.159.0.0-34.159.255.255,34.141.0.0-34.141.127.255,34.88.0.0-34.88.255.255";
        private string naEastIpRanges = "35.236.192.0-35.236.255.255,35.199.0.0-35.199.63.255,34.86.0.0-34.86.255.255,35.245.0.0-35.245.255.255,35.186.160.0-35.186.191.255,34.145.128.0-34.145.255.255,34.150.128.0-34.150.255.255,34.85.128.0-34.85.255.255";
        private string naCentralIpRanges = "24.105.40.0-24.105.47.255";
        private string naWest1IpRanges = "24.105.8.0-24.105.15.255";
        private string naWest2IpRanges = "35.247.0.0-35.247.127.255,35.236.0.0-35.236.127.255,35.235.70.0-35.235.130.255,34.102.0.0-34.102.127.255,34.94.0.0-34.94.255.255";
        private string naWest3IpRanges = "34.19.0.0-34.19.127.255,34.82.0.0-34.83.255.255,34.105.0.0-34.105.127.255,34.118.192.0-34.118.199.255,34.127.0.0-34.127.127.255,34.145.0.0-34.145.127.255,34.157.112.0-34.157.119.255,34.157.240.0-34.157.247.255,34.168.0.0-34.169.255.255,35.185.192.0-35.185.255.255,35.197.0.0-35.197.127.255,35.199.144.0-35.199.159.255,35.199.160.0-35.199.191.255,35.203.128.0-35.203.191.255,35.212.128.0-35.212.255.255,35.220.48.0-35.220.55.255,35.227.128.0-35.227.191.255,35.230.0.0-35.230.127.255,35.233.128.0-35.233.255.255,35.242.48.0-35.242.55.255,35.243.32.0-35.243.39.255,35.247.0.0-35.247.127.255";
        public void playOnNA()
        {
            Type typeFWPolicy2 = Type.GetTypeFromCLSID(new Guid(guidFWPolicy2));
            Type typeFWRule = Type.GetTypeFromCLSID(new Guid(guidRWRule));
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(typeFWPolicy2);
            INetFwRule newRule = (INetFwRule)Activator.CreateInstance(typeFWRule);
            newRule.Name = "1OW_PLAY_NA";
            newRule.Description = "Block EU and MENA IP Addresses to play on NA servers.";
            newRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_ANY;
            newRule.RemoteAddresses = eu1IpRanges + "," + eu2IpRanges + "," + menaIpRanges; //fill all ip addresses in the string
            newRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT; //outbound rule
            newRule.Enabled = true;
            newRule.Grouping = "@firewallapi.dll,-23255";
            newRule.Profiles = fwPolicy2.CurrentProfileTypes;
            newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
            fwPolicy2.Rules.Add(newRule);
        }
        public void playOnMiddleEast()
        {
            Type typeFWPolicy2 = Type.GetTypeFromCLSID(new Guid(guidFWPolicy2));
            Type typeFWRule = Type.GetTypeFromCLSID(new Guid(guidRWRule));
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(typeFWPolicy2);
            INetFwRule newRule = (INetFwRule)Activator.CreateInstance(typeFWRule);
            newRule.Name = "1OW_PLAY_MIDDLE_EAST";
            newRule.Description = "Block EU and NA IP Addresses to play on Middle East servers.";
            newRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_ANY;
            newRule.RemoteAddresses = eu1IpRanges + "," + eu2IpRanges + "," + naCentralIpRanges + "," + naEastIpRanges + "," + naWest1IpRanges
                + "," + naWest2IpRanges + "," + naWest3IpRanges; //fill all ip addresses in the string
            newRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT; //outbound rule
            newRule.Enabled = true;
            newRule.Grouping = "@firewallapi.dll,-23255";
            newRule.Profiles = fwPolicy2.CurrentProfileTypes;
            newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
            fwPolicy2.Rules.Add(newRule);
        }

        public void deleteRules()
        {
            Type typeFWPolicy2 = Type.GetTypeFromCLSID(new Guid(guidFWPolicy2));
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(typeFWPolicy2);
            fwPolicy2.Rules.Remove("1OW_PLAY_NA");
            fwPolicy2.Rules.Remove("1OW_PLAY_MIDDLE_EAST");
        }
    }
}

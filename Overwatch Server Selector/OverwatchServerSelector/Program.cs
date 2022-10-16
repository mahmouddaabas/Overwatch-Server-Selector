using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetFwTypeLib;

namespace OverwatchServerSelector
{
    internal class Program
{

    const string guidFWPolicy2 = "{E2B3C97F-6AE1-41AC-817A-F6F92166D7DD}";
    const string guidRWRule = "{2C5BC43E-3369-4C33-AB0C-BE9469677AF4}";
    private INetFwPolicy2 fwPolicy2;
    private string euIpRangesOneString = "35.198.64.0-35.198.191.255,34.107.0.0-34.107.127.255,35.195.0.0-35.195.255.255," +
        "35.246.0.0-35.246.255.255,35.228.0.0-35.228.255.255,34.89.128.0-34.89.255.255,35.242.128.0-35.242.255.255," +
        "34.159.0.0-34.159.255.255,34.141.0.0-34.141.127.255,5.42.168.0-5.42.191.255,34.88.0.0-34.88.255.255";
    private string menaIpRangesOneString = "157.175.0.0-157.175.255.255,15.185.0.0-15.185.255.255,15.184.0.0-15.184.255.255";

    public void addRuleBlockEUandMENA()
    {
        Type typeFWPolicy2 = Type.GetTypeFromCLSID(new Guid(guidFWPolicy2));
        Type typeFWRule = Type.GetTypeFromCLSID(new Guid(guidRWRule));
        fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(typeFWPolicy2);
        INetFwRule newRule = (INetFwRule)Activator.CreateInstance(typeFWRule);
        newRule.Name = "1OW_PLAY_NA";
        newRule.Description = "Block EU and MENA IP Addresses to play on NA.";
        //newRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP; //TCP
        //newRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP; //UDP
        newRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_ANY; //TCP AND UDP
                                                                            //newRule.LocalPorts = "4000"; //if you need to specifiy port
        newRule.RemoteAddresses = euIpRangesOneString + "," + menaIpRangesOneString; //fill all ip addresses in the string.
                                                                                     //newRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN; //inbound rule
        newRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT; //outbound rule
        newRule.Enabled = true;
        newRule.Grouping = "@firewallapi.dll,-23255";
        newRule.Profiles = fwPolicy2.CurrentProfileTypes;
        newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
        fwPolicy2.Rules.Add(newRule);
    }

    public void deleteRule()
    {
        fwPolicy2.Rules.Remove("1OW_PLAY_NA");
    }

    public void startProgram()
    {
        Console.WriteLine("Overwatch Server Selector V1.0 by Mahe\n");
        Console.WriteLine("Select an option by writing a number:");
        Console.WriteLine("1. Block EU and Middle East.");
        try
        {
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    addRuleBlockEUandMENA();
                    Console.WriteLine("\nStarted blocking Europe and Middle East servers.");
                    break;

                default:
                    Console.WriteLine("Invalid input, select something from the list.\n");
                    startProgram();
                    break;
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine("Please enter a number that is available in the list.\n");
            startProgram();
        }
    }

    static void Main(string[] args)
    {
        Program pm = new Program();
        pm.startProgram();

        Console.WriteLine("Close the program to stop blocking.");
        Console.ReadLine(); //to stop console from auto closing
        pm.deleteRule(); //delete rule when application is closed
    }
}
}

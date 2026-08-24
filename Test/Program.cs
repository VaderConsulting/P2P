using System;
using System.Collections.Generic;
using System.Text;
using System.Net.PeerToPeer;
using System.Net;

namespace PnrpSamples
{
    // http://msdn.microsoft.com/en-us/library/bb968783(v=vs.90).aspx
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a secure (not spoofable) PeerName
            PeerName peerName = new PeerName("VaderConsulting.PharmacyDocs." + Environment.MachineName, PeerNameType.Secured);

            PeerNameRegistration pnReg = new PeerNameRegistration();
            pnReg.PeerName = peerName;
            pnReg.Port = 8082;

            Cloud PeerCloud = pnReg.Cloud;

            //OPTIONAL
            //The properties set below are optional.  You can register a PeerName without setting these properties
            pnReg.Comment = "up to 39 unicode char comment";
            pnReg.Data = System.Text.Encoding.UTF8.GetBytes("A data blob associated with the name");  // Maximum of 4Kb
            
            /*
             * OPTIONAL
             *The properties below are also optional, but will not be set (ie. are commented out) for this example
             *pnReg.IPEndPointCollection = // a list of all {IPv4/v6 address, port} pairs to associate with the peername
             *pnReg.Cloud = //the scope in which the name should be registered (local subnet, internet, etc)
            */

            //Starting the registration means the name is published for others to resolve
            pnReg.Start();
            Console.WriteLine("Registration of Peer Name: {0} complete.", peerName.ToString());
            Console.WriteLine();
            Console.WriteLine("Press any key to stop the registration and close the program");
            Console.ReadKey();
            
            pnReg.Stop();
        }
    }
}

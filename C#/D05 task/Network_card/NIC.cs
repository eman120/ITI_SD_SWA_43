using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_card
{
    enum TYPE : byte
    {
        Ethernet = 1, token, ring
    }
    internal class NIC
    {
        string Manufacture, macAddress;
        TYPE type;


        public static NIC getNIC { get; } = new NIC("MAC",
           "3B97D8D4-C708-42BC-9F21-64CADDCC002D",
           (TYPE)1
        );

        public override string ToString()
        {
            return $"Manufacture: {Manufacture}\nmacAddress: {macAddress}\ntype: {type} ";
        }

        NIC(string man , string mac , TYPE typ)
        {
            Manufacture = man;
            macAddress = mac;
            type = typ;
        }
    }
}

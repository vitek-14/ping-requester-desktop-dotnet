using PingRequester.Data.Base;
using PingRequester.Data.DataObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingRequester.Data.Containers
{
    /// <summary>
    /// Collection class of Packet data object.
    /// </summary>
    public class PacketCollection
    {
        private Queue<Packet> packets;

        /// <summary>
        /// Default constructor of the PacketCollection class.
        /// </summary>
        public PacketCollection()
        {
        }

        public Queue<Packet> Packets { get; set; }
    }
}

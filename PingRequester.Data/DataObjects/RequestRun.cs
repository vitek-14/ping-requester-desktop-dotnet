using PingRequester.Data.Base;
using PingRequester.Data.Containers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PingRequester.Data.DataObjects
{
    public class RequestRun : DataObject
    {
        private Requester requester;
        private string ipAdress;
        private Queue<Packet> packets;

        public RequestRun(Requester requester)
        {
            this.requester = requester;
            Packets = new Queue<Packet>();
        }

        public Queue<Packet> Packets
        {
            get => packets;
            set => SetProperty(ref packets, value);
        }
    }
}

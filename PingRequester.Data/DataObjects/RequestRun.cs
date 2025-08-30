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
        private string hostname;
        private string ipv4;
        private int packetsSent;
        private int packetsRecieved;
        private int packetsLost;
        private DateTime start;
        private DateTime end;
        private int maxTime;
        private int minTime;
        private float averageTime;
        private Queue<Packet> packets;

        public RequestRun()
        {
            Packets = new Queue<Packet>();
        }

        public Queue<Packet> Packets
        {
            get => packets;
            set => SetProperty(ref packets, value);
        }

        public string Hostname
        {
            get => hostname;
            set => SetProperty(ref hostname, value);
        }

        public string Ipv4
        {
            get => ipv4;
            set => SetProperty(ref ipv4, value);
        }

        public int PacketsSent 
        { 
            get => packetsSent;
            set => SetProperty(ref packetsSent, value);
        }

        public int PacketsRecieved
        { 
            get => packetsRecieved;
            set => SetProperty(ref packetsRecieved, value);
        }

        public int PacketsLost
        {
            get => packetsLost;
            set => SetProperty(ref packetsLost, value);
        }

        public DateTime Start
        {
            get => start;
            set => SetProperty(ref start, value);
        }

        public DateTime End
        {
            get => end;
            set => SetProperty(ref end, value);
        }

        public int MaxTime
        {
            get => maxTime;
            set => SetProperty(ref maxTime, value);
        }

        public int MinTime
        {
            get => minTime;
            set => SetProperty(ref minTime, value);
        }

        public float AverageTime
        {
            get => averageTime;
            set => SetProperty(ref averageTime, value);
        }
    }
}

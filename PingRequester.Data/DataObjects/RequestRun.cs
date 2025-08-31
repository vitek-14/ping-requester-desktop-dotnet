using PingRequester.Data.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private int packetSize;
        private int packetsSent;
        private int packetsRecieved;
        private int packetsLost;
        private DateTime start;
        private DateTime end;
        private int maxTime;
        private int minTime;
        private float averageTime;
        private Queue<Packet> packets;
        private ProcessStartInfo psi;

        public RequestRun(string hostname, int packetSize)
        {
            Packets = new Queue<Packet>();
            Hostname = hostname;
            PacketSize = packetSize;
        }

        public void Init()
        {
            Psi = new ProcessStartInfo
            {
                FileName = "ping",
                Arguments = $"-n 1 {IPv4} -l {PacketSize}",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
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

        public string IPv4 { get; set; }

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

        public int PacketSize
        {
            get => packetSize;
            set => SetProperty(ref packetSize, value);
        }

        public ProcessStartInfo Psi
        {
            get => psi;
            set => SetProperty(ref psi, value);
        }
    }
}

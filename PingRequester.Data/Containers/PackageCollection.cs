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
    public class PackageCollection
    {
        private Queue<Package> packages;

        public PackageCollection()
        {
        }

        public Queue<Package> Packages { get; set; }
    }
}

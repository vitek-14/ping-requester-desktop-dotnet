using PingRequester.Tests.business.DataFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PingRequester.Tests.business
{
    public class DatabaseTests : DatabaseTestBase, IClassFixture<DatabaseTestBase>
    {
        public DatabaseTests() : base()
        {
        }


    }
}

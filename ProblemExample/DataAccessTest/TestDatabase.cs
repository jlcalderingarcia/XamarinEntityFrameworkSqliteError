using System;
using DataAccessTest.EF;

namespace DataAccessTest
{
    public class TestDatabase
    {
        public static void TestDatabasePermissions(string databaseName){
			var context = new EFContext(databaseName);
			context.Database.EnsureDeleted();
			context.Database.EnsureCreated();
        }
    }
}

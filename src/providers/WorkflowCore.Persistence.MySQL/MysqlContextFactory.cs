

using System;
using MySql.EntityFrameworkCore.Infrastructure;
using WorkflowCore.Persistence.EntityFramework.Interfaces;
using WorkflowCore.Persistence.EntityFramework.Services;

namespace WorkflowCore.Persistence.MySQL
{
    public class MysqlContextFactory : IWorkflowDbContextFactory
    {
        private readonly string _connectionString;
        private readonly Action<MySQLDbContextOptionsBuilder> _mysqlOptionsAction;

        public MysqlContextFactory(string connectionString, Action<MySQLDbContextOptionsBuilder> mysqlOptionsAction = null)
        {
            _connectionString = connectionString;
            _mysqlOptionsAction = mysqlOptionsAction;
        }

        public WorkflowDbContext Build()
        {
            return new MysqlContext(_connectionString, _mysqlOptionsAction);
        }
    }
}

﻿using System;
using System.Data;
using Wjire.Db.Dapper.SqlServer.Connection;

namespace Wjire.Db.Dapper
{
    /// <summary>
    /// 工作单元接口
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        IDbConnection Connection { get; set; }
        IDbTransaction Transaction { get; set; }
        Func<IDbConnection, IDbTransaction> TransactionFactory { get; }
        void Commit();
        void Rollback();

        IConnectionFactoryProvider ConnectionFactoryProvider { get; set; }
        string ConnectionStringName { get; set; }
    }
}

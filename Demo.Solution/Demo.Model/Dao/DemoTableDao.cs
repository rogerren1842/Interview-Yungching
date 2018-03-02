using Dapper;
using Demo.Model.Model.Entity;
using Demo.Tool;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace Demo.Model.Dao
{
    /// <summary>
    /// 資料存取層(展示主檔)
    /// </summary>
    public class DemoTableDao
    {
        /// <summary>
        /// 新增
        /// </summary>
        public void Create(DemoTable Data)
        {
            var sql = @"INSERT INTO DemoTable Values(@Id,@Name,@Gender)";

            using (var connection = new SqlConnection(ConfigTool.GetDbConnectionStrings()))
            {
                connection.Open();

                var transaction = connection.BeginTransaction();
                try
                {
                    connection.Execute(sql, Data, transaction);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        /// <summary>
        /// 更新
        /// </summary>
        public void Update(DemoTable Data)
        {
            var sql = @"
                UPDATE DemoTable 
                SET Id=@Id,Name=@Name,Gender=@Gender
                WHERE Id=@Id";

            using (var connection = new SqlConnection(ConfigTool.GetDbConnectionStrings()))
            {
                connection.Open();

                var transaction = connection.BeginTransaction();
                try
                {
                    connection.Execute(sql, Data, transaction);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        /// <summary>
        /// 閱讀
        /// </summary>
        public DemoTable Read(DemoTable Data)
        {
            var sql = @"SELECT * FROM DemoTable(NOLOCK) WHERE Id=@Id";

            using (var connection = new SqlConnection(ConfigTool.GetDbConnectionStrings()))
            {
                try
                {
                    var result = connection.Query<DemoTable>(sql, Data).ToList();
                    return result.Count > 0 ? result.First() : null;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// 刪除
        /// </summary>
        public void Delete(DemoTable Data)
        {
            var sql = @"DELETE FROM DemoTable WHERE Id=@Id";

            using (var connection = new SqlConnection(ConfigTool.GetDbConnectionStrings()))
            {
                connection.Open();

                var transaction = connection.BeginTransaction();
                try
                {
                    connection.Execute(sql, Data, transaction);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }
    }
}

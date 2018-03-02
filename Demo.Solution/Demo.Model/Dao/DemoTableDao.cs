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
            var sql = @"INSERT INTO DemoDB Values(@Id,@Name,@Gender)";

            var parameters = new DynamicParameters();
            parameters.Add("@Id", Data.Id);
            parameters.Add("@Name", Data.Name);
            parameters.Add("@Gender", Data.Gender);

            using (var connection = new SqlConnection(ConfigTool.GetDbConnectionStrings()))
            {
                var transaction = connection.BeginTransaction();
                try
                {
                    connection.Execute(sql, parameters);
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
                UPDATE DemoDB 
                SET Id=@Id,Name=@Name,Gender=@Gender
                WHERE Id=@Id";

            var parameters = new DynamicParameters();
            parameters.Add("@Id", Data.Id);
            parameters.Add("@Name", Data.Name);
            parameters.Add("@Gender", Data.Gender);

            using (var connection = new SqlConnection(ConfigTool.GetDbConnectionStrings()))
            {
                var transaction = connection.BeginTransaction();
                try
                {
                    connection.Execute(sql, parameters);
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

            var parameters = new DynamicParameters();
            parameters.Add("@Id", Data.Id);

            using (var connection = new SqlConnection(ConfigTool.GetDbConnectionStrings()))
            {
                try
                {
                    var result = connection.Query<DemoTable>(sql, parameters).ToList();
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

            var parameters = new DynamicParameters();
            parameters.Add("@Id", Data.Id);

            using (var connection = new SqlConnection(ConfigTool.GetDbConnectionStrings()))
            {
                var transaction = connection.BeginTransaction();
                try
                {
                    connection.Execute(sql, parameters);
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

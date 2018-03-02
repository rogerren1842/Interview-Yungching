using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Model.Dao;
using Demo.Model.Model.Entity;

namespace Demo.Model.Service
{
    /// <summary>
    /// 商業邏輯層(展示功能)
    /// </summary>
    public class DemoService
    {
        /// <summary>
        /// 資料存取層(展示主檔)
        /// </summary>
        public DemoTableDao DemoTableDao = new DemoTableDao();

        #region 展示功能

        /// <summary>
        /// 新增
        /// </summary>
        public void Create(DemoTable Data)
        {
            try
            {
                this.DemoTableDao.Create(Data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 更新
        /// </summary>
        public void Update(DemoTable Data)
        {
            try
            {
                this.DemoTableDao.Update(Data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 閱讀
        /// </summary>
        public DemoTable Read(DemoTable Data)
        {
            try
            {
                return this.DemoTableDao.Read(Data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 刪除
        /// </summary>
        public void Delete(DemoTable Data)
        {
            try
            {
                this.DemoTableDao.Delete(Data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}

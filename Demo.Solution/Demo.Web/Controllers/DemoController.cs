using Demo.Model.Model.Entity;
using Demo.Model.Model.View;
using Demo.Model.Service;
using System;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Demo.Web.Controllers
{
    /// <summary>
    /// 控制器(展示功能)
    /// </summary>
    public class DemoController : Controller
    {
        /// <summary>
        /// 商業邏輯層(展示功能)
        /// </summary>
        public DemoService DemoService = new DemoService();

        /// <summary>
        /// 首頁
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        #region 展示功能

        /// <summary>
        /// 查詢
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public JsonResult Read(DemoTable model)
        {
            var result = new ResultModel()
            {
                ExecuteResult = "執行成功",
                QueryResult = ""
            };

            try
            {
                var queryResult = this.DemoService.Read(model);
                result.QueryResult = queryResult != null ? new JavaScriptSerializer().Serialize(queryResult) : "查無資料";
            }
            catch (Exception ex)
            {
                result.ExecuteResult = string.Format("執行失敗(錯誤原因：{0})", ex.Message);
            }

            return Json(result);
        }

        /// <summary>
        /// 編輯
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public JsonResult Update(DemoTable model)
        {
            var result = new ResultModel()
            {
                ExecuteResult = "執行成功",
                QueryResult = ""
            };

            try
            {
                this.DemoService.Update(model);
            }
            catch (Exception ex)
            {
                result.ExecuteResult = string.Format("執行失敗(錯誤原因：{0})", ex.Message);
            }

            return Json(result);
        }

        /// <summary>
        /// 建立
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public JsonResult Create(DemoTable model)
        {
            var result = new ResultModel()
            {
                ExecuteResult = "執行成功",
                QueryResult = ""
            };

            try
            {
                this.DemoService.Create(model);
            }
            catch (Exception ex)
            {
                result.ExecuteResult = string.Format("執行失敗(錯誤原因：{0})", ex.Message);
            }

            return Json(result);
        }

        /// <summary>
        /// 刪除
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public JsonResult Delete(DemoTable model)
        {
            var result = new ResultModel()
            {
                ExecuteResult = "執行成功",
                QueryResult = ""
            };

            try
            {
                this.DemoService.Delete(model);
            }
            catch (Exception ex)
            {
                result.ExecuteResult = string.Format("執行失敗(錯誤原因：{0})", ex.Message);
            }

            return Json(result);
        }

        #endregion
    }
}
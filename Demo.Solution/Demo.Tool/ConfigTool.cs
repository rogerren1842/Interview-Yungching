using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Demo.Tool
{
    /// <summary>
    /// Config取得工具
    /// </summary>
    public static class ConfigTool
    {
        /// <summary>
        /// 取得DB連線資訊
        /// </summary>
        public static string GetDbConnectionStrings(string Key = "DefaultConnection")
        {
            return ConfigurationManager.ConnectionStrings[Key].ConnectionString.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Demo.Model.Model.Entity
{
    /// <summary>
    /// 展示主檔
    /// </summary>
    public class DemoTable
    {
        /// <summary>
        /// ID
        /// </summary>
        [Display(Name = "ID")]
        public string Id { set; get; }

        /// <summary>
        /// 姓名
        /// </summary>
        [Display(Name = "姓名")]
        public string Name { set; get; }

        /// <summary>
        /// 性別
        /// </summary>
        [Display(Name = "性別")]
        public string Gender { set; get; }
    }
}

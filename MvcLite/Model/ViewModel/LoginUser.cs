using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Model.ViewModel
{
    /// <summary>
    /// 登陆视图 模型
    /// </summary>
    public class LoginUser
    {
        [Required (ErrorMessage = "用户不能为空")]
        public string LoginName { get; set; }
        [Required(ErrorMessage ="密码不能为空")]
        public string Pwd { get; set; }
        public bool IsAlways { get; set; }
    }
}

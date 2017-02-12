using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TmTech_v1
{
    public class UserSetting
    {
        public string UserName { get; set; }
        public string ThemeName { get; set; }
        public UserSetting()
        {
            UserName = string.Empty;
            ThemeName = string.Empty;
        }
    }
}

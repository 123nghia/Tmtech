using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace TmTech_v1.Utility
{
 public class NotificationMessage
    {
     
     public static string MsgSuccess { get {return MesgBox.MsgSuccess.ToString(); } }
     public static string MsgUnsuccess { get { return MesgBox.MsgUnSccess.ToString(); } }
     public static string MsgMissingData { get { return MesgBox.MsgMissingData.ToString(); } }

    }
}

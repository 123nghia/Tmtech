﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TmTech_v1 {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class MesgBox {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MesgBox() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TmTech_v1.MesgBox", typeof(MesgBox).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mã không được để trống.
        /// </summary>
        internal static string MsgCodeNotNull {
            get {
                return ResourceManager.GetString("MsgCodeNotNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Số điện thoại không hợp lệ.
        /// </summary>
        internal static string MsgInValidPhone {
            get {
                return ResourceManager.GetString("MsgInValidPhone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mã sản phẩm không hợp lệ.
        /// </summary>
        internal static string MsgInValidProduct {
            get {
                return ResourceManager.GetString("MsgInValidProduct", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thiếu dữ liệu input..
        /// </summary>
        internal static string MsgMissingData {
            get {
                return ResourceManager.GetString("MsgMissingData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tên không được để trống.
        /// </summary>
        internal static string MsgNameNotNull {
            get {
                return ResourceManager.GetString("MsgNameNotNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bạn có chắc muốn xóa?.
        /// </summary>
        internal static string MSGRemoveItem {
            get {
                return ResourceManager.GetString("MSGRemoveItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thành công.
        /// </summary>
        internal static string MsgSuccess {
            get {
                return ResourceManager.GetString("MsgSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Không thành công.
        /// </summary>
        internal static string MsgUnSccess {
            get {
                return ResourceManager.GetString("MsgUnSccess", resourceCulture);
            }
        }
    }
}

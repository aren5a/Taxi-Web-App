﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Taxi.Common {
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
    public class TaxiResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TaxiResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Taxi.Common.TaxiResource", typeof(TaxiResource).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to در ارتباط با دیتابیس اشکالی پیش آمد.
        /// </summary>
        public static string DBError {
            get {
                return ResourceManager.GetString("DBError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to شناسه یا رمز عبور اشتباه است.
        /// </summary>
        public static string Login_Err {
            get {
                return ResourceManager.GetString("Login_Err", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to موضوع و شرح خبر را  به طور کامل وارد نمایید.
        /// </summary>
        public static string News_Insert {
            get {
                return ResourceManager.GetString("News_Insert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to موضوع و شرح خبر را به طور کامل وارد نمایید.
        /// </summary>
        public static string News_Submit_Err {
            get {
                return ResourceManager.GetString("News_Submit_Err", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to تاریخ یا تعداد سرویس صحیح وارد نشده.
        /// </summary>
        public static string User_by_Service_Date_err {
            get {
                return ResourceManager.GetString("User_by_Service_Date_err", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to کاربر مورد جستجو یافت نشد.
        /// </summary>
        public static string User_NotFound_Err {
            get {
                return ResourceManager.GetString("User_NotFound_Err", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to اطلاعات وارد شده اشتباه می باشد.
        /// </summary>
        public static string User_Submit {
            get {
                return ResourceManager.GetString("User_Submit", resourceCulture);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;

namespace UI_TestSuite
{
    static class AppManager
    {
        const string ApkPath = "";
        const string AppPath = "";
        const string IpaBundled = "";

        static IApp app;
        public static IApp app
        {
            get
            {
                if (app == null)
                {
                    throw new NullReferenceException("'AppManager.App' not set.")
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Def
{
    public static class DefSetting
    {
        public static RuntimePlatform RuntimePlatform;

        public static void UseDefault()
        {
            RuntimePlatform = RuntimePlatform.Default;
        }

        public static void UseDotNetFiddle()
        {
            RuntimePlatform = RuntimePlatform.DotNetFiddle;
        }
    }
}

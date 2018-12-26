using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01.Services
{
    sealed class FeatureCache
    {
        private static object s_InstanceCacheLock = new object();

        private static FeatureCache s_Instance;

        public static FeatureCache Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_InstanceCacheLock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new FeatureCache();
                        }
                    }

                }

                return s_Instance;
            }
        }
    }
}

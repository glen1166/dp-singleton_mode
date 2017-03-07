using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonMode
{
    public class AzureStorageManager
    {
        public static AzureStorageManager _instance = null;

        public static object _lock = new object();

        private AzureStorageManager() { }

        public static AzureStorageManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {

                        if (_instance == null)
                        {
                            try
                            {
                                _instance = new AzureStorageManager();
                            }
                            catch (Exception e)
                            {
                                throw e;
                            }
                        }
                    }
                }

                return _instance;
            }
        }
    }
}

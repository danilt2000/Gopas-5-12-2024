namespace SingletonDemo
{
    public class Config
    {

        //v1
        //private static Config? instance;
        //private static Object instanceLock = new Object();

        //v2
        private static Lazy<Config> instance = new Lazy<Config>(() => new Config(42),  true);

        private int answer;
        public int Answer => answer;

        private Config(int answer) { 
            this.answer = answer;
        }
        //v1
        //public static Config Instance { 
        //    get {
        //        if (instance == null)
        //            lock (instanceLock) {
        //                if (instance == null) instance = new Config();
        //            }
        //        return instance;
        //    }
        //}

        //v2
        public static Config Instance => instance.Value;
    }
}

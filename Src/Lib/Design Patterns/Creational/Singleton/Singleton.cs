namespace software_craftsmanship.Lib.Design_Patterns.Creational.Singleton
{
    public class Singleton
    {
        private static Singleton _privateSingleton;
        public static Singleton PublicSingleton;
        private static readonly object Padlock   = new object();

        public Singleton()
        {
            
        }

        /*
         *  Not Thread Safe
         *  Two different threads could both have evaluated the test if (instance==null) and found it to be true,
         *  then both create instances, which violates the singleton pattern.
         */
        public static Singleton InstanceBadExample
        {
            get
            {
                if (_privateSingleton == null)
                {
                    _privateSingleton = new Singleton();
                }
                return _privateSingleton;
            }
        }

        /*
         *  Thread Safe
         *  Takes out a lock on a shared object, and then checks whether or not the instance has been
         *  created before creating the instance. Unfortunately, performance suffers as a lock is
         *  acquired every time the instance is requested.
         */

        public static Singleton InstanceGoodExample
        {
            get
            {
                lock (Padlock)
                {
                    if (_privateSingleton == null)
                    {
                        _privateSingleton = new Singleton();
                    }
                }

                return _privateSingleton;
            }
        }

        /*
         * static constructors in C# are specified to execute only when an instance of the class is created
         * or a static member is referenced, and to execute only once per AppDomain
         */
        static Singleton()
        {

        }

        public static Singleton SimpleInstanceExampleWithStaticConstructor => PublicSingleton;

        public void ResetForTesting()
        {
            _privateSingleton = null;
            PublicSingleton = null;
        }
    }
}

namespace Singleton.Singleton
{
    class Unique
    {
        private static Unique _uniqueInstance;
        private Unique() { }

        public static Unique getInstance()
        {
            if (_uniqueInstance == null)
            {
                _uniqueInstance = new Unique();
            }
            return _uniqueInstance;
        }
    }
}
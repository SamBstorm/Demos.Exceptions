using System;

namespace Demos.Exceptions.CommonObjects
{
    public static class ExceptionsFactory
    {
        public static void BadArgument()
        {
            throw new ArgumentException();
        }

        public static void NotImplemented()
        {
            throw new NotImplementedException();
        }

    }
}

using System;

namespace NetCore3.Lib
{
    public class SomeDependency : ISomeDependency
    {
        public bool IsValid(string value)
        {
            throw new NotImplementedException();
        }
    }
}

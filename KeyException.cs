using System;

namespace Encrypter
{
    class KeyException : Exception
    {
        public KeyException(string message) : base(message) { }
    }
}

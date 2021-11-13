using System;

namespace SnakeLadder.Core.GameExceptions
{
    public class InvalidPlayerNameException : Exception
    {
        public InvalidPlayerNameException(string message) : base(message) { }

        public InvalidPlayerNameException(string message, Exception innerException) : base(message, innerException) { }
    }
}
using System;

namespace SnakeLadder.Core.GameExceptions
{
    public class DuplicatePortalException : Exception
    {
        public DuplicatePortalException(string message) : base(message) { }

        public DuplicatePortalException(string message, Exception innerException) : base(message, innerException) { }
    }
}
using System;

namespace DP1
{
    public class UserDoesNotExistsException : Exception
    {
        public UserDoesNotExistsException(string message) : base(message)
        {
        }
    }

    public class UserAlreadyExistsException : Exception
    {
        public UserAlreadyExistsException(string message) : base(message)
        {
        }
    }
}
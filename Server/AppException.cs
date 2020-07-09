using System;
using System.Runtime.Serialization;

namespace Server
{

    [Serializable]
    // Important: This attribute is NOT inherited from Exception, and MUST be specified 
    // otherwise serialization will fail with a SerializationException stating that
    // "Type X in Assembly Y is not marked as serializable."
    public class AppException : Exception
    {
        public AppException()
        {
        }

        public AppException(string message)
            : base(message)
        {
        }

        public AppException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        // Without this constructor, deserialization will fail
        protected AppException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }

}

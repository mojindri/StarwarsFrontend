using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazerMovies.Exceptions
{
    public class UnknownHttpResponseException : Exception
    {
        public UnknownHttpResponseException(string status):base("unknown message with status code "+ status+ "from server ")
        {
                
        }
    }
}

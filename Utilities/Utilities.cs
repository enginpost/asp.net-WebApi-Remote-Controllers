using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Utilities
{
    public class StatusResponse
    {

        public enum STATUS
        {
            NO_CONTENT = 204,
            FOUND = 302,
            BAD_REQUEST = 400
        }
        public STATUS Status { get; set; }
        public string MessageType { get; set; }
        public object Message { get; set; }
    }
    public class MESSAGE_TYPE
    {
        public const String ERROR = "ERROR";
        public const String RESULT = "RESULT";
    }
}

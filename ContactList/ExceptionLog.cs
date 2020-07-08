using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList
{
    public class ExceptionLog
    {
        private List<LoggedException> _loggedExceptions;

        public ExceptionLog()
        {
            _loggedExceptions = new List<LoggedException>();
        }

        public bool LogException(Exception e)
        {
            if (e != null)
            {
                _loggedExceptions.Add(new LoggedException(e));
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<LoggedException> GetAllLoggedExceptions()
        {
            return _loggedExceptions;
        }
    }

    public class LoggedException
    {
        public LoggedException(Exception e)
        {
            Date = DateTime.Now;
            Exception = e;
        }

        public DateTime Date { get; private set; }

        public Exception Exception { get; private set; }
    }
}

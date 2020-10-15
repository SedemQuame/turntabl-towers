using System;
using System.Collections.Generic;
using System.Text;

namespace turntabl_towers
{
    class NobodyHomeException:Exception
    {
        public NobodyHomeException(string reason) : base(reason) { }
        public NobodyHomeException(string reason, Exception cause): base(reason, cause) { }
    }
}

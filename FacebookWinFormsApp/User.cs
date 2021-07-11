using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
   public class User
    {

        public String m_FirstName { get; set; }
        public String m_LastName { get; set; }
        public String m_UrlPic { get; set; }
        public ICollection m_Groups { get; set; }
        public ICollection m_Friends { get; set; }

    }
}

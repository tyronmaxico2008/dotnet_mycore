using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NTier.Request
{

    
    public partial class utility
    {
    
        public static iBussinessTier createBussinessTierFromXmlForWeb(clsAppServerBase oAppServerInfo)
        {
            clsBussinessTierFromXmlBase obj = new clsBussinessTierFromXmlForWeb(oAppServerInfo);
            return obj;
        }


        public static iBussinessTier createBussinessTierFromXmlForWeb2(clsAppServerBase oAppServerInfo,string sMainApp)
        {
            clsBussinessTier2 obj = new clsBussinessTier2(oAppServerInfo,sMainApp);
            return obj;
        }

    }
}

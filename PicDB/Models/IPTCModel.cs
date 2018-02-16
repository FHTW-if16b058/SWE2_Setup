using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.Models;

namespace PicDB.Models
{
    /*! \brief TBA */
    public class IPTCModel : IIPTCModel
    {
        /*! \brief A list of keywords */
        public string Keywords { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Name of the photographer */
        public string ByLine { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Copyright notices */
        public string CopyrightNotice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Summary/Headline of the picture */
        public string Headline { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Caption/Abstract, a description of the picture */
        public string Caption { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB.ViewModels
{
    /*! \brief TBA */
    public class IPTCViewModel : IIPTCViewModel
    {
        /*! \brief A list of keywords */
        public string Keywords { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Name of the photographer */
        public string ByLine { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Copyright notices */
        public string CopyrightNotice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief A list of common copyright notices, e.g. All rights reserved, CC-BY, CC-BY-SA, CC-BY-ND, CC-BY-NC, CC-BY-NC-SA, CC-BY-NC-ND */
        public IEnumerable<string> CopyrightNotices => throw new NotImplementedException();

        /*! \brief Summary/Headline of the picture */
        public string Headline { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Caption/Abstract, a description of the picture */
        public string Caption { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

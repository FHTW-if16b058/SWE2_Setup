using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB.ViewModels
{
    /*! \brief TBA */
    public class SearchViewModel : ISearchViewModel
    {
        /*! \brief The search text */
        public string SearchText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief True, if a search is active */
        public bool IsActive => throw new NotImplementedException();

        /*! \brief Number of photos found */
        public int ResultCount => throw new NotImplementedException();
    }
}

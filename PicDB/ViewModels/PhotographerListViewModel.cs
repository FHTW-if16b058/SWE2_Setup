using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB.ViewModels
{
    /*! \brief TBA */
    public class PhotographerListViewModel : IPhotographerListViewModel
    {
        /*! \brief List of all photographer viewmodels */
        public IEnumerable<IPhotographerViewModel> List => throw new NotImplementedException();

        /*! \brief The currently selected photographer viewmodel */
        public IPhotographerViewModel CurrentPhotographer => throw new NotImplementedException();
    }
}

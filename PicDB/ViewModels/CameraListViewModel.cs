using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB.ViewModels
{
    /*! \brief TBA */
    public class CameraListViewModel : ICameraListViewModel
    {
        /*! \brief List of all camera-list viewmodels */
        public IEnumerable<ICameraViewModel> List => throw new NotImplementedException();

        /*! \brief The currently selected camera-list viewmodel */
        public ICameraViewModel CurrentCamera => throw new NotImplementedException();
    }
}

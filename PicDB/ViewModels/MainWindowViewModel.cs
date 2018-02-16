using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.ViewModels;


namespace PicDB.ViewModels
{
    /*! \brief TBA */
    public class MainWindowViewModel : IMainWindowViewModel
    {
        /*! \brief The current picture viewmodel */
        public IPictureViewModel CurrentPicture => throw new NotImplementedException();

        /*! \brief Viewmodel with a list of all pictures */
        public IPictureListViewModel List => throw new NotImplementedException();

        /*! \brief Search viewmodel */
        public ISearchViewModel Search => throw new NotImplementedException();
    }
}

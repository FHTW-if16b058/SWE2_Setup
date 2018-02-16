using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB.ViewModels
{
    /*! \brief TBA */
    public class PictureListViewModel : IPictureListViewModel
    {
        /*! \brief Viewmodel of the current picture */
        public IPictureViewModel CurrentPicture => throw new NotImplementedException();

        /*! \brief List of all picture viewmodels */
        public IEnumerable<IPictureViewModel> List => throw new NotImplementedException();

        /*! \brief All previous pictures to the currently selected picture */
        public IEnumerable<IPictureViewModel> PrevPictures => throw new NotImplementedException();

        /*! \brief All next pictures to the currently selected picture */
        public IEnumerable<IPictureViewModel> NextPictures => throw new NotImplementedException();

        /*! \brief Number of all images */
        public int Count => throw new NotImplementedException();

        /*! \brief The current index, 1 based */
        public int CurrentIndex => throw new NotImplementedException();

        /*! \brief {CurrentIndex} of {Cout} as string */
        public string CurrentPictureAsString => throw new NotImplementedException();
    }
}

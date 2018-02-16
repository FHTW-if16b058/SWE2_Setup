using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB.ViewModels
{
    /*! \brief TBA */
    public class PictureViewModel : IPictureViewModel
    {
        /*! \brief Database primary key */
        public int ID => throw new NotImplementedException();

        /*! \brief Name of the file */
        public string FileName => throw new NotImplementedException();

        /*! \brief Full file path, used to load the image */
        public string FilePath => throw new NotImplementedException();

        /*! \brief The line below the picture; format: {IPTC.Headline|FileName} (by {Photographer|IPTC.ByLine}) */
        public string DisplayName => throw new NotImplementedException();

        /*! \brief The IPTC viewmodel */
        public IIPTCViewModel IPTC => throw new NotImplementedException();

        /*! \brief The EXIF viewmodel */
        public IEXIFViewModel EXIF => throw new NotImplementedException();

        /*! \brief The photographer viewmodel */
        public IPhotographerViewModel Photographer => throw new NotImplementedException();

        /*! \brief The camera viewmodel */
        public ICameraViewModel Camera => throw new NotImplementedException();
    }
}

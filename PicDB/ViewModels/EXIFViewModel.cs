using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB.ViewModels
{
    /*! \brief TBA */
    public class EXIFViewModel : IEXIFViewModel
    {
        /*! \brief Name of camera */
        public string Make => throw new NotImplementedException();

        /*! \brief Aperture number */
        public decimal FNumber => throw new NotImplementedException();

        /*! \brief Exposure time */
        public decimal ExposureTime => throw new NotImplementedException();

        /*! \brief ISO value */
        public decimal ISOValue => throw new NotImplementedException();

        /*! \brief Flash yes/no */
        public bool Flash => throw new NotImplementedException();

        /*! \brief The exposure program as string */
        public string ExposureProgram => throw new NotImplementedException();

        /*! \brief The Exposure Program as image resource */
        public string ExposureProgramResource => throw new NotImplementedException();

        /*! \brief Gets or sets an optional camera viewmodel. */
        public ICameraViewModel Camera { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Returns an ISO rating if a camera is set. */
        public ISORatings ISORating => throw new NotImplementedException();

        /*! \brief Returns an image resource of a ISO rating if a camera is set. */
        public string ISORatingResource => throw new NotImplementedException();
    }
}

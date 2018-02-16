using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.Models;

namespace PicDB.Models
{
    /*! \brief TBA */
    public class EXIFModel : IEXIFModel
    {
        /*! \brief Name of camera */
        public string Make { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Aperture number */
        public decimal FNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Exposure time */
        public decimal ExposureTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief ISO value */
        public decimal ISOValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Flash yes/no */
        public bool Flash { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief The exposure program */
        public ExposurePrograms ExposureProgram { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

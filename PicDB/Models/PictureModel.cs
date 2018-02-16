using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.Models;

namespace PicDB.Models
{
    /*! \brief TBA */
    public class PictureModel : IPictureModel
    {
        /*! \brief Database primary key */
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Filename of the picture, without path */
        public string FileName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief IPTC information */
        public IIPTCModel IPTC { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief EXIF information */
        public IEXIFModel EXIF { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief The camera (optional) */
        public ICameraModel Camera { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.Models;

namespace PicDB.Models
{
    /*! \brief TBA */
    public class CameraModel : ICameraModel
    {
        /*! \brief Database primary key */
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Name of the producer */
        public string Producer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Name of camera */
        public string Make { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Optional: date, when the camera was bought */
        public DateTime? BoughtOn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Notes */
        public string Notes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Max ISO Value for good results; 0 means "not defined" */
        public decimal ISOLimitGood { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! Max ISO Value for acceptable results; 0 means "not defined" */
        public decimal ISOLimitAcceptable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

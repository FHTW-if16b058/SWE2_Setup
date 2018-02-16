using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.Models;

namespace PicDB.Models
{
    /*! \brief TBA */
    public class PhotographerModel : IPhotographerModel
    {
        /*! \brief Database primary key */
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Firstname, including middle name */
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Lastname */
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Birthday */
        public DateTime? BirthDay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Notes */
        public string Notes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

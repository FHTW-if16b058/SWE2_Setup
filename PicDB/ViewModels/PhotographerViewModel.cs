using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB.ViewModels
{
    /*! \brief TBA */
    public class PhotographerViewModel : IPhotographerViewModel
    {
        /*! \brief Database primary key */
        public int ID => throw new NotImplementedException();

        /*! \brief Firstname, including middle name */
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Lastname */
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief BirthDay */
        public DateTime? BirthDay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Notes */
        public string Notes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Returns the number of pictures. */
        public int NumberOfPictures => throw new NotImplementedException();

        /*! \brief Returns true, if the model is valid. */
        public bool IsValid => throw new NotImplementedException();

        /*! \brief Returns a summary of validation errors. */
        public string ValidationSummary => throw new NotImplementedException();

        /*! \brief Returns true if the last name is valid. */
        public bool IsValidLastName => throw new NotImplementedException();

        /*! \brief Returns true if the birthday is valid. */
        public bool IsValidBirthDay => throw new NotImplementedException();
    }
}

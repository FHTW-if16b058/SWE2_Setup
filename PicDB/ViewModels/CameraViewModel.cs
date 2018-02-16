using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB.ViewModels
{
    /*! \brief TBA */
    public class CameraViewModel : ICameraViewModel
    {
        /*! \brief Database primary key */
        public int ID => throw new NotImplementedException();

        /*! \brief Name of the producer */
        public string Producer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Name of camera */
        public string Make { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Optional: date, when the camera was bought */
        public DateTime? BoughtOn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Notes */
        public string Notes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Returns the number of pictures. */
        public int NumberOfPictures => throw new NotImplementedException();

        /*! \brief Returns true, if the model is valid. */
        public bool IsValid => throw new NotImplementedException();

        /*! \brief Returns a summary of validation errors */
        public string ValidationSummary => throw new NotImplementedException();

        /*! \brief Returns true if the producer name is valid. */
        public bool IsValidProducer => throw new NotImplementedException();

        /*! \brief Returns true if the make is valid. */
        public bool IsValidMake => throw new NotImplementedException();

        /*! \brief Returns true if the "bought on" date is valid. */
        public bool IsValidBoughtOn => throw new NotImplementedException();

        /*! \brief Max ISO Value for good results. 0 means "not defined" */
        public decimal ISOLimitGood { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Max ISO Value for acceptable results. 0 means "not defined" */
        public decimal ISOLimitAcceptable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*! \brief Translates a given ISO value to a ISO rating. */
        public ISORatings TranslateISORating(decimal iso)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.Models;
using BIF.SWE2.Interfaces.ViewModels;
using PicDB;

namespace Uebungen
{
    /*! \brief Contains UEB4-implementations */
    public class UEB4 : IUEB4
    {
        /*! \brief This method is only called to prove the unit test setup. */
        public void HelloWorld()
        {
        }

        /*! \brief Returns a business layer instance. */
        public IBusinessLayer GetBusinessLayer()
        {
            throw new NotImplementedException();
        }

        /*! \brief This method is called before any test is run; used to check preparation for unit-testing. */
        public void TestSetup(string picturePath)
        {

        }

        /*! \brief Returns an empty EXIF model. */
        public IEXIFModel GetEmptyEXIFModel()
        {
            throw new NotImplementedException();
        }

        /*! \brief Returns an EXIF viewmodel representing the given model. */
        public IEXIFViewModel GetEXIFViewModel(IEXIFModel mdl)
        {
            throw new NotImplementedException();
        }

        /*! \brief Returns an empty IPTC model. */
        public IIPTCModel GetEmptyIPTCModel()
        {
            throw new NotImplementedException();
        }

        /*! \brief Returns an IPTC viewmodel representing the given model. */
        public IIPTCViewModel GetIPTCViewModel(IIPTCModel mdl)
        {
            throw new NotImplementedException();
        }

        /*! \brief Returns a camera model. */
        public ICameraModel GetCameraModel(string producer, string make)
        {
            throw new NotImplementedException();
        }

        /*! \brief Returns a camera viewmodel representing the given model. */
        public ICameraViewModel GetCameraViewModel(ICameraModel mdl)
        {
            throw new NotImplementedException();
        }
    }
}

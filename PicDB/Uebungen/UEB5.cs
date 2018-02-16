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
    /*! \brief Contains UEB5-implementations */
    public class UEB5 : IUEB5
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

        /*! \brief Returns an empty photographer model. */
        public IPhotographerModel GetEmptyPhotographerModel()
        {
            throw new NotImplementedException();
        }

        /*! \brief Returns a photographer viewmodel representing the given model. */
        public IPhotographerViewModel GetPhotographerViewModel(IPhotographerModel mdl)
        {
            throw new NotImplementedException();
        }

        /*! \brief Returns an empty camera model. */
        public ICameraModel GetEmptyCameraModel()
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

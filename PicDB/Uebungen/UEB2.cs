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
    /*! \brief Contains UEB2-implementations */
    public class UEB2 : IUEB2
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

        /*! \brief Returns the mainWindow viewmodel. */
        public BIF.SWE2.Interfaces.ViewModels.IMainWindowViewModel GetMainWindowViewModel()
        {
            throw new NotImplementedException();
        }

        /*! \brief Returns a picture model. */
        public BIF.SWE2.Interfaces.Models.IPictureModel GetPictureModel(string filename)
        {
            throw new NotImplementedException();
        }

        /*! \brief Returns a picture viewmodel. */
        public BIF.SWE2.Interfaces.ViewModels.IPictureViewModel GetPictureViewModel(BIF.SWE2.Interfaces.Models.IPictureModel mdl)
        {
            throw new NotImplementedException();
        }

        /*! \brief This method is called before any test is run; used to check preparation for unit-testing. */
        public void TestSetup(string picturePath)
        {

        }

        /*! \brief Returns a camera model. */
        public ICameraModel GetCameraModel(string producer, string make)
        {
            throw new NotImplementedException();
        }

        /*! \brief Returns a camera viewmodel. */
        public ICameraViewModel GetCameraViewModel(ICameraModel mdl)
        {
            throw new NotImplementedException();
        }
    }
}

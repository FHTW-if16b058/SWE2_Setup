using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.Models;
using BIF.SWE2.Interfaces.ViewModels;
using PicDB;
using PicDB.Models;
using PicDB.ViewModels;
using PicDB.BusinessLayer;
using PicDB.DataAccessLayer;

namespace Uebungen
{
    /*! \brief Contains UEB1-implementations */
    public class UEB1 : IUEB1
    {
        /*! \brief Returns an instance of the WPF application class. */
        public IApplication GetApplication()
        {
            return new App();
        }

        /*! \brief This method is only called to prove the unit test setup. */
        public void HelloWorld()
        {
            // I'm fine
        }

        /*! \brief Returns a data access layer instance. It does not matter if it's a real one or the MockDAL for unit-tests. */
        public IDataAccessLayer GetAnyDataAccessLayer()
        {
            return new DataAccessLayer();
        }

        /*! \brief Returns a business layer instance. */
        public IBusinessLayer GetBusinessLayer()
        {
            return new BusinessLayer();
        }

        /*! \brief Returns an empty EXIF model. */
        public BIF.SWE2.Interfaces.Models.IEXIFModel GetEmptyEXIFModel()
        {
            return new EXIFModel();
        }

        /*! \brief Returns an empty EXIF viewmodel. */
        public BIF.SWE2.Interfaces.ViewModels.IEXIFViewModel GetEmptyEXIFViewModel()
        {
            return new EXIFViewModel();
        }

        /*! \brief Returns an empty IPCT model. */
        public BIF.SWE2.Interfaces.Models.IIPTCModel GetEmptyIPTCModel()
        {
            return new IPTCModel();
        }

        /*! \brief Returns an empty IPCT viewmodel. */
        public BIF.SWE2.Interfaces.ViewModels.IIPTCViewModel GetEmptyIPTCViewModel()
        {
            return new IPTCViewModel();
        }

        /*! \brief Returns an empty main window viewmodel. */
        public BIF.SWE2.Interfaces.ViewModels.IMainWindowViewModel GetEmptyMainWindowViewModel()
        {
           return new MainWindowViewModel();
        }

        /*! \brief Returns an empty photographer-list viewmodel. */
        public BIF.SWE2.Interfaces.ViewModels.IPhotographerListViewModel GetEmptyPhotographerListViewModel()
        {
            return new PhotographerListViewModel();
        }

        /*! \brief Returns an empty photographer model. */
        public BIF.SWE2.Interfaces.Models.IPhotographerModel GetEmptyPhotographerModel()
        {
            return new PhotographerModel();
        }

        /*! \brief Returns an empty photographer viewmodel. */
        public BIF.SWE2.Interfaces.ViewModels.IPhotographerViewModel GetEmptyPhotographerViewModel()
        {
            return new PhotographerViewModel();
        }

        /*! \brief Returns an empty picture-list viewmodel. */
        public BIF.SWE2.Interfaces.ViewModels.IPictureListViewModel GetEmptyPictureListViewModel()
        {
            return new PictureListViewModel();
        }

        /*! \brief Returns an empty picture model. */
        public BIF.SWE2.Interfaces.Models.IPictureModel GetEmptyPictureModel()
        {
            return new PictureModel();
        }

        /*! \brief Returns an empty picture viewmodel. */
        public BIF.SWE2.Interfaces.ViewModels.IPictureViewModel GetEmptyPictureViewModel()
        {
            return new PictureViewModel();
        }

        /*! \brief Returns an empty search viewmodel. */
        public BIF.SWE2.Interfaces.ViewModels.ISearchViewModel GetEmptySearchViewModel()
        {
            return new SearchViewModel();
        }

        /*! \brief This method is called before any test is run; used to check preparation for unit-testing. */
        public void TestSetup(string picturePath)
        {

        }

        /*! \brief Returns an empty camera model */
        public ICameraModel GetEmptyCameraModel()
        {
            return new CameraModel();
        }

        /*! \brief Returns an empty camera-list viewmodel. */
        public ICameraListViewModel GetEmptyCameraListViewModel()
        {
            return new CameraListViewModel();
        }

        /*! \brief Returns an empty camera viewmodel. */
        public ICameraViewModel GetEmptyCameraViewModel()
        {
            return new CameraViewModel();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.ViewModels;
using PicDB;

namespace Uebungen
{
    /*! \brief Contains UEB3-implementations */
    public class UEB3 : IUEB3
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

        /*! \brief Returns a mock data access layer. */
        public IDataAccessLayer GetDataAccessLayer()
        {
            throw new NotImplementedException();
        }

        /*! \brief Returns a search viewmodel. */
        public ISearchViewModel GetSearchViewModel()
        {
            throw new NotImplementedException();
        }
    }
}

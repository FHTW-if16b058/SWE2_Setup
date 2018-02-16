using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.Models;

namespace PicDB.BusinessLayer
{
    /*! \brief TBA */
    public class BusinessLayer : IBusinessLayer
    {
        #region Pictures
        /*! \brief Deletes a picture from the database AND from the file system. */
        public void DeletePicture(int ID)
        {
            throw new NotImplementedException();
        }

        /*! \brief Returns ONE picture from the database. */
        public IPictureModel GetPicture(int ID)
        {
            throw new NotImplementedException();
        }

        /*! \brief Returns a list of ALL pictures from the directory, based on a database query. */
        public IEnumerable<IPictureModel> GetPictures()
        {
            throw new NotImplementedException();
        }

        /*! \brief Returns a filterd list of pictures from the directory, based on a database query. */
        public IEnumerable<IPictureModel> GetPictures(string namePart, IPhotographerModel photographerParts, IIPTCModel iptcParts, IEXIFModel exifParts)
        {
            throw new NotImplementedException();
        }

        /*! \brief Saves all changes to the database. */
        public void Save(IPictureModel picture)
        {
            throw new NotImplementedException();
        }

        /*! \brief Syncs the picture folder with the database. */
        public void Sync()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Photographers
        /*! \brief Deletes a photographer; an exception is thrown if a photographer is still linked to a picture. */
        public void DeletePhotographer(int ID)
        {
            throw new NotImplementedException();
        }

        /*! \brief Returns ONE photographer. */
        public IPhotographerModel GetPhotographer(int ID)
        {
            throw new NotImplementedException();
        }

        /*! \brief Returns a list of ALL photographers. */
        public IEnumerable<IPhotographerModel> GetPhotographers()
        {
            throw new NotImplementedException();
        }

        /*! \brief Saves all changes. */
        public void Save(IPhotographerModel photographer)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IPTC, EXIF
        /*! \brief Extracts EXIF information from a picture; NOTE: you may simulate the action. */
        public IEXIFModel ExtractEXIF(string filename)
        {
            throw new NotImplementedException();
        }

        /*! \brief Extracts IPTC information from a picture; NOTE: you may simulate the action. */
        public IIPTCModel ExtractIPTC(string filename)
        {
            throw new NotImplementedException();
        }

        /*! \brief Returns ONE camera. */
        public ICameraModel GetCamera(int ID)
        {
            throw new NotImplementedException();
        }

        /*! \brief Returns a list of ALL cameras. */
        public IEnumerable<ICameraModel> GetCameras()
        {
            throw new NotImplementedException();
        }

        /*! \brief Writes IPTC information back to a picture; NOTE: you may simulate the action. */
        public void WriteIPTC(string filename, IIPTCModel iptc)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

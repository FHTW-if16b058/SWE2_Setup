using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.Models;

namespace PicDB.DataAccessLayer
{
    /*! \brief TBA */
    public class DataAccessLayer : IDataAccessLayer
    {
        #region Pictures
        /*! \brief Deletes a Picture from the database. */
        public void DeletePicture(int ID)
        {
            throw new NotImplementedException();
        }

        /*! \brief Returns ONE Picture from the database. */
        public IPictureModel GetPicture(int ID)
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
        #endregion

        #region Photgraphers
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

        /*! \brief Returns a list of ALL Photographers. */
        public IEnumerable<IPhotographerModel> GetPhotographers()
        {
            throw new NotImplementedException();
        }

        /*! \brief Saves all changes to the database. */
        public void Save(IPhotographerModel photographer)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IPTC, EXIF
        /*! \brief Returns ONE Camera */
        public ICameraModel GetCamera(int ID)
        {
            throw new NotImplementedException();
        }

        /*! \brief Returns a list of ALL Cameras. */
        public IEnumerable<ICameraModel> GetCameras()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

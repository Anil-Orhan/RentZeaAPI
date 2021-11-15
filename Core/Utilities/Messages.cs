using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    public static class Messages
    {
        #region GeneralMessages
        public static string Added = "Added!";
        public static string Deleted = "Deleted!";
        public static string Updated = "Updated!";
        public static string Listed = "Listed!";
        public static string Error = "An error has occurred!";
        public static string IdError = "The ID value is defined automatically. Please delete the ID value!";
        #endregion

        #region carMessages
        public static string carPriceError = "Price must be greater than 0!";
        public static string carDetail = "Car Details Have Been Brought";
        public static string carAdded = "New Car Added!";
        public static string carDeleted = "Car Deleted!";
        public static string carUpdated = "Car Updated!";
        public static string carListed = "Car List Brought!";
        public static string carById = "Car Brought!";
        #endregion
        
     
    }
}

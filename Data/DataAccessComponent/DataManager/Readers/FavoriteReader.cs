

#region using statements

using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Readers
{

    #region class FavoriteReader
    /// <summary>
    /// This class loads a single 'Favorite' object or a list of type <Favorite>.
    /// </summary>
    public class FavoriteReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'Favorite' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'Favorite' DataObject.</returns>
            public static Favorite Load(DataRow dataRow)
            {
                // Initial Value
                Favorite favorite = new Favorite();

                // Create field Integers
                int idfield = 0;
                int namefield = 1;
                int passwordfield = 2;
                int startPagefield = 3;
                int urlfield = 4;
                int userNamefield = 5;

                try
                {
                    // Load Each field
                    favorite.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    favorite.Name = DataHelper.ParseString(dataRow.ItemArray[namefield]);
                    favorite.Password = DataHelper.ParseString(dataRow.ItemArray[passwordfield]);
                    favorite.StartPage = DataHelper.ParseBoolean(dataRow.ItemArray[startPagefield], false);
                    favorite.Url = DataHelper.ParseString(dataRow.ItemArray[urlfield]);
                    favorite.UserName = DataHelper.ParseString(dataRow.ItemArray[userNamefield]);
                }
                catch
                {
                }

                // return value
                return favorite;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'Favorite' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A Favorite Collection.</returns>
            public static List<Favorite> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<Favorite> favorites = new List<Favorite>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'Favorite' from rows
                        Favorite favorite = Load(row);

                        // Add this object to collection
                        favorites.Add(favorite);
                    }
                }
                catch
                {
                }

                // return value
                return favorites;
            }
            #endregion

        #endregion

    }
    #endregion

}

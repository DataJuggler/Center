

#region using statements

using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class Favorite
    [Serializable]
    public partial class Favorite
    {

        #region Private Variables
        #endregion

        #region Constructor
        public Favorite()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public Favorite Clone()
            {
                // Create New Object
                Favorite newFavorite = (Favorite) this.MemberwiseClone();

                // Return Cloned Object
                return newFavorite;
            }
        #endregion

            #region ToString()
            /// <summary>
            /// method returns the String
            /// </summary>
            public override string ToString()
            {
                // return the name
                return Name;
            }
            #endregion
            
        #endregion

        #region Properties
        #endregion

    }
    #endregion

}

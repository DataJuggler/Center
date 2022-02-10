

#region using statements

using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class BlockedSite
    public partial class BlockedSite
    {

        #region Private Variables
        private int id;
        private string name;
        private string password;
        private string url;
        #endregion

        #region Methods

            #region UpdateIdentity(int id)
            // <summary>
            // This method provides a 'setter'
            // functionality for the Identity field.
            // </summary>
            public void UpdateIdentity(int id)
            {
                // Update The Identity field
                this.id = id;
            }
            #endregion

        #endregion

        #region Properties

            #region int Id
            public int Id
            {
                get
                {
                    return id;
                }
            }
            #endregion

            #region string Name
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            #endregion

            #region string Password
            public string Password
            {
                get
                {
                    return password;
                }
                set
                {
                    password = value;
                }
            }
            #endregion

            #region string Url
            public string Url
            {
                get
                {
                    return url;
                }
                set
                {
                    url = value;
                }
            }
            #endregion

            #region bool IsNew
            public bool IsNew
            {
                get
                {
                    // Initial Value
                    bool isNew = (this.Id < 1);

                    // return value
                    return isNew;
                }
            }
            #endregion

        #endregion

    }
    #endregion

}

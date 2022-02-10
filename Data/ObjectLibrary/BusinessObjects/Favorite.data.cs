

#region using statements

using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class Favorite
    public partial class Favorite
    {

        #region Private Variables
        private int id;
        private string name;
        private string password;
        private bool startPage;
        private string url;
        private string userName;
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

            #region bool StartPage
            public bool StartPage
            {
                get
                {
                    return startPage;
                }
                set
                {
                    startPage = value;
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

            #region string UserName
            public string UserName
            {
                get
                {
                    return userName;
                }
                set
                {
                    userName = value;
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

Use [Center]

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: BlockedSite_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   2/10/2022
-- Description:    Insert a new BlockedSite
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('BlockedSite_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure BlockedSite_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.BlockedSite_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure BlockedSite_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure BlockedSite_Insert >>>'

    End

GO

Create PROCEDURE BlockedSite_Insert

    -- Add the parameters for the stored procedure here
    @Name nvarchar(50),
    @Password nvarchar(40),
    @Url nvarchar(255)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [BlockedSite]
    ([Name],[Password],[Url])

    -- Begin Values List
    Values(@Name, @Password, @Url)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: BlockedSite_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   2/10/2022
-- Description:    Update an existing BlockedSite
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('BlockedSite_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure BlockedSite_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.BlockedSite_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure BlockedSite_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure BlockedSite_Update >>>'

    End

GO

Create PROCEDURE BlockedSite_Update

    -- Add the parameters for the stored procedure here
    @Id int,
    @Name nvarchar(50),
    @Password nvarchar(40),
    @Url nvarchar(255)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [BlockedSite]

    -- Update Each field
    Set [Name] = @Name,
    [Password] = @Password,
    [Url] = @Url

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: BlockedSite_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   2/10/2022
-- Description:    Find an existing BlockedSite
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('BlockedSite_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure BlockedSite_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.BlockedSite_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure BlockedSite_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure BlockedSite_Find >>>'

    End

GO

Create PROCEDURE BlockedSite_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Name],[Password],[Url]

    -- From tableName
    From [BlockedSite]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: BlockedSite_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   2/10/2022
-- Description:    Delete an existing BlockedSite
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('BlockedSite_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure BlockedSite_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.BlockedSite_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure BlockedSite_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure BlockedSite_Delete >>>'

    End

GO

Create PROCEDURE BlockedSite_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [BlockedSite]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: BlockedSite_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   2/10/2022
-- Description:    Returns all BlockedSite objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('BlockedSite_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure BlockedSite_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.BlockedSite_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure BlockedSite_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure BlockedSite_FetchAll >>>'

    End

GO

Create PROCEDURE BlockedSite_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Name],[Password],[Url]

    -- From tableName
    From [BlockedSite]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Favorite_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   2/10/2022
-- Description:    Insert a new Favorite
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Favorite_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Favorite_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Favorite_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Favorite_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Favorite_Insert >>>'

    End

GO

Create PROCEDURE Favorite_Insert

    -- Add the parameters for the stored procedure here
    @Name nvarchar(50),
    @Password nvarchar(40),
    @StartPage bit,
    @Url nvarchar(255),
    @UserName nvarchar(40)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [Favorite]
    ([Name],[Password],[StartPage],[Url],[UserName])

    -- Begin Values List
    Values(@Name, @Password, @StartPage, @Url, @UserName)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Favorite_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   2/10/2022
-- Description:    Update an existing Favorite
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Favorite_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Favorite_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Favorite_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Favorite_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Favorite_Update >>>'

    End

GO

Create PROCEDURE Favorite_Update

    -- Add the parameters for the stored procedure here
    @Id int,
    @Name nvarchar(50),
    @Password nvarchar(40),
    @StartPage bit,
    @Url nvarchar(255),
    @UserName nvarchar(40)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [Favorite]

    -- Update Each field
    Set [Name] = @Name,
    [Password] = @Password,
    [StartPage] = @StartPage,
    [Url] = @Url,
    [UserName] = @UserName

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Favorite_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   2/10/2022
-- Description:    Find an existing Favorite
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Favorite_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Favorite_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Favorite_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Favorite_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Favorite_Find >>>'

    End

GO

Create PROCEDURE Favorite_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Name],[Password],[StartPage],[Url],[UserName]

    -- From tableName
    From [Favorite]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Favorite_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   2/10/2022
-- Description:    Delete an existing Favorite
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Favorite_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Favorite_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Favorite_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Favorite_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Favorite_Delete >>>'

    End

GO

Create PROCEDURE Favorite_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [Favorite]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Favorite_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   2/10/2022
-- Description:    Returns all Favorite objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Favorite_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Favorite_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Favorite_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Favorite_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Favorite_FetchAll >>>'

    End

GO

Create PROCEDURE Favorite_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Name],[Password],[StartPage],[Url],[UserName]

    -- From tableName
    From [Favorite]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Launch_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   2/10/2022
-- Description:    Insert a new Launch
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Launch_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Launch_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Launch_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Launch_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Launch_Insert >>>'

    End

GO

Create PROCEDURE Launch_Insert

    -- Add the parameters for the stored procedure here
    @LaunchDate datetime,
    @SiteId uniqueidentifier,
    @Url nvarchar(512)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [Launch]
    ([LaunchDate],[SiteId],[Url])

    -- Begin Values List
    Values(@LaunchDate, @SiteId, @Url)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Launch_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   2/10/2022
-- Description:    Update an existing Launch
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Launch_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Launch_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Launch_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Launch_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Launch_Update >>>'

    End

GO

Create PROCEDURE Launch_Update

    -- Add the parameters for the stored procedure here
    @Id int,
    @LaunchDate datetime,
    @SiteId uniqueidentifier,
    @Url nvarchar(512)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [Launch]

    -- Update Each field
    Set [LaunchDate] = @LaunchDate,
    [SiteId] = @SiteId,
    [Url] = @Url

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Launch_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   2/10/2022
-- Description:    Find an existing Launch
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Launch_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Launch_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Launch_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Launch_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Launch_Find >>>'

    End

GO

Create PROCEDURE Launch_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[LaunchDate],[SiteId],[Url]

    -- From tableName
    From [Launch]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Launch_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   2/10/2022
-- Description:    Delete an existing Launch
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Launch_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Launch_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Launch_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Launch_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Launch_Delete >>>'

    End

GO

Create PROCEDURE Launch_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [Launch]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Launch_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   2/10/2022
-- Description:    Returns all Launch objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Launch_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Launch_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Launch_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Launch_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Launch_FetchAll >>>'

    End

GO

Create PROCEDURE Launch_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[LaunchDate],[SiteId],[Url]

    -- From tableName
    From [Launch]

END

-- Thank you for using DataTier.Net.


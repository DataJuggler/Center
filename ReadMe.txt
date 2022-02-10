You will need SQL Server or SQL Server Express to use this product.

Instructions
1. In SQL Server Manager Studio, create database named Center
2. Execute the SQL Script CenterDatabase.sql, located in the SQL Folder.
3. Create a connection string to your database.
If you want a free tool called Connection String Builder, clone DataTier.Net, and
look in the Tools folder for Connection String Builder.

DataTier.Net
https://github.com/DataJuggler/DataTier.Net

Or change out the values for server from these templates:



Windows Authentication (Recommended)

Data Source=[Server Name];Initial Catalog=Center;Integrated Security=True



SQL Server Authentication

Data Source=[Server Name];Initial Catalog=Center;Integrated Security=False;
User ID="[User Name]";Password="[User Password]"

Once you have your connectionstring, copy it to your clipboard.

In Windows search, type Edit System Environment Variables - after you type a few characters 
Windows should show the link to edit the system environment variables.

Once the tool opens, click on the Environment Variables button.
In the bottom section, select 'New'.

In the box that pops up, enter:

Name: CenterConnString
Value: (Paste in your connection string)

Hit OK to Save and close the Environment Variables window.

That should be all you have to do.

Known issues and To Do List:

1. Have not written intellisense type look up of your favorites yet. You must type in teh full
url to go to a site for now.

2. Paste & Go hasn't been written yet. You can paste in text and hit enter. I need a context menu
option for paste and go.

3. If you change sites, the UrlTextBox displays the new address. If you go to a sub topic
of the current site, I need to find what event fires, because it doesn't update.

4. Blocked Sites hasn't been written yet. I created the table for it. This could serve as either
either a parental or work environment block, or even if you have sites with too many ads
you would rather not visit. 

5. The right ad cover, has a right click to restore. The left one doesn't yet. Need to ad that.

Favorite Feature:

My favorite feature of this browser, is the built in Ad Cover on the left and right sides.
You can pull out a black box to cover up ads or even video ads so you can read the 
article you came to the site for, better.

It is definately far from perfect. One odd thing though, Center works on HBO Max,
which for some reason my edge stopped playing after I turned off Zune Windows Service.

Let me know if you have any questions. I will build a release soon. Just build your project in
Visual Studio and create a shortcut on your desktop for now.

Let me know of any bugs not mentioned or features you would like to see.

Thanks,

Corby / Data Juggler







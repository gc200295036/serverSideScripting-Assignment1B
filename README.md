# serverSideScripting-Assignment1B

This application is to be able to create a category that will assign said category an integer Id
then the "Items" page is so a user can add more information about users example(name,email etc) and it will  connect both tables with the auto-id from category.

I uploaded my project to Azure:

link: https://serversidescripting.azurewebsites.net/

. Bonus #1: Customize the theme by adding either your own CSS or an
additional open-source theme (on top of Bootstrap) to give your site a
different look from the standard .NET MVC template with Bootstrap. If you
use a pre-built theme or css library you must cite the source with a comment
in your _Layout.cshtml file AND in your README.md file.

- I used a prebuilt layout : https://bootswatch.com/darkly/

Bonus #2: Add an advanced .NET MVC feature that we have not yet learned
in class. You MUST document this feature in the README.md so I know what
to look for.

Data annotations:

[Display(Name = "Name")]
public string FirstName { get; set; }
        
        adding the data annotation on line 16 will change the display of FirstName on a webpage. This was helpful when I wanted to rename column.
        It doesn't change it in the database but it will change it for the user.

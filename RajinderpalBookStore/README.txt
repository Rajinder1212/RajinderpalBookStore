Student name : Rajinderpal Singh
Student Id : 0803629
Assignment purpose : Creating an MVC application for BookStore . 
31/OCTOBER/2022 0815 
The application was created with 
3.1 LTS and have Individual account set up 
and it has https config
commeted the lauch setthis in properties foldr 
checked the application 
0829
options => options.SignIn.RequireConfirmedAccount = true)// comment 33 line in startup folder 
addes a read me.md file
0837
Insert a two red break points in homecontroller.cs in  index and privacy  
after running the application dotted points are highlighted with yelow color and shows step by step procedure
updated the boostrap.css file with cyborg coming from bootswatch website
changethe site css with the new code of my theme also created a backup file for bootstrap.css
view/shared/layout.cshtml change 8 line  to bootstrap.min.css to .css
 change light to dark navbar and bg-white to primary in layout.cshtml
 <!-- removed text dark--> in line23 and 26
  in footer add addition properties
  removed text dark in line 9 ,20 and 23
  tested thec applixcation
    and it wroks in first attemp hurray!!!!
  0910
  2022-02-11
  0736
  working on the applications
  rebuild the application 
  and test the application 
 in layout.cshml added css an javascript links
  added a drop down menu in views/shared/layout.cshtml
  run it....
  it works well.
  0752
  Created new 3 projects 
  copy the data folder and paste into .data access  and renamed the origional name to data_bk
  0808
  install identity.frameworkcore.relation in the dataaccess folder
  namespace modified in ApplicationDbContext.cs
  deleted migrations and downloaded new pakages 
   deleted all class.cs files in all new three proect
  copy models folder into Rajinderpal.models
  and renamed
   added a project reference for models and data access
  0829
   rename models folder to view models
  added a .viewmodels in error.viewmodel.cs to its namespace
  0836
  added public static in sd.cs
   added a new project reference in main folder
   added new area folder in areas named as customer
   0847
   changes the routes in startup.cs 
added a new words area.exists
   0849
   move controllers into customer in areas folder and delete models and data
    [Area("Customer")] in homecontroller.cs
     move views into controller
     coorected the errors i the error.html file 
I Have no errors still my application lost its connection with local host 
changed the location for shared 
and changed the start up file 

started 2 part`

2022-11-04    0541
created a new folder name admin in areas, then deleted models and data folder.
0547
move the view folder into the admin folder

1051
In appsetting.json did changes to default connection

1055
use this command add-migration AddDefaultIdentityMigration for adding a migration

1130
while creating migration it is created in Rajinderpalbook store instead of .Dataaccess file

1132
while adding command it asked for specify what context you want  then build failed
but it works in original file
20221105025349_AddDefaultIdentityMigration  this is migration file name

1146
in .model folder added a new class name category.cs and modified the project

1158
added the migration 
updated ApplicationDbContext.cs
line 06 and 16
11-10-2022 
0131
I got error for reference error for application db context..
In applicationdbcontext in data access folder correct the reference namespace
in startup made vchanges for  using statment to refer the application dbcontext file

0134
Added migration for adddefaultidentity migration
20221110183025_AddDefaultIdentityMigration.cs

0135
updated database
0148

Deleted old migration and created new migration 
updated the database

0226
add repository
then add Irepository
added using stements and given lines

0241
added a new class Respository.cs in respostory folder 
Add content which is given by sir 
Also added using statements

11-11-2022
0436
created interface called IRepository folder named ICategoryRepository

0518
in repository folder added a categoryRepository class 
made changes acccording to ppt

0522
added a new item called ISP_Call.cs in Irepository folder

0545
added a lot of content in ISP_call.cs carfully..

11-14-2022
0304
aded new class in respository named SP_Call.cs

added a huge content in SP_Call.cs with using statements

0321
added new using statement named     using Microsoft.Data.SqlClient; 

Again I got errors then I click on potential errors and fixed it

0346
added a new interface in Irepository
 added content

 0416
 added UnitOfWork 

 1016
 added content in UNItOfWork.
 1022
 added content and updated startup

1024
added class in controller called category.cs

1034 added content in categorycontroller.cs

11-44-2022
1044
I got error in adding content in categoryController.cs
Now I have resolved it . and it works

1100
added a new view named index.cshtml
1121
remove / from index.cshtml

11-18-2022
0158
added a content in _layout.cshtml

0216
added font in index.cshtml

0224
added @section in index.cshtml

0236
added content in categoryController.cs

0239
add category in view in index.cshtml
0244
added a view in upsert named Upsert.cshtml
added content in upsert.cshtml

0252
added view named _CreatetoBackTolistButton.cshtml

0258
added another view called _EditandBackToListButton.cshtml

0319
added content in upsert.cshtml again

0348
added @model and @section content in the upsert.cshml and index.cshtml 
updated the IUnitOfWork 

2022-11-21
0253

InvalidOperationException: The constraint reference 'Admin' could not be resolved to a type. Register the constraint type with 'Microsoft.AspNetCore.Routing.RouteOptions.ConstraintMap'.
Did changes in categorycontroller.cs
views.import.cshtml changed layout
In unitofwork.cs added : Iunitofwork

0313
InvalidOperationException: The constraint reference 'Admin' could not be resolved to a type.Register the constraint type with 'Microsoft.AspNetCore.Routing.RouteOptions.ConstraintMap'.
Solution added the route for admin in startup.cs it resolved

0315
In _layout.cshtml correct the catgory name in drop down menu
In categorycontroller.cs  added IUnitofwork
And added void Save

0347
added content in category.js

0537
coreected all the small errors 
but still i m not able to use my create category button 
Did changes in categorycontroller.cs

0544
Added a new class named covertype.cs in models folder

0546
added Name and Id in covertype.cs

0552
added new item in IRepository named ICoverTypeRepository.cs

2022-11-22
0832
corrected small errors for connecting the button  and  added the view file in the Admin folder of views 

0834
added content om covertype.cs & added 2properties of id and name as same as category.cs

0855
add covertyperepository class
add ICoverTypeRepository Intrface
add CoverType to UnitOfWork and IUnitOfWork
push CoverType to the database 

2022-11-24

added migration for the CoverType 
and Added the CoverType for the refernce in the ApplicationdbContext 

0802
added an CoverTypeController in the admin folder in controllers  and new overType in the views to add index and upsert files and made changs 
updated the IcategoryRepository to fix erros 
added the link for coverType n the nav in the _layout file 

20221124124125_AddCoverTypeToDb   name for coverType for migration 

0812 
added a new file in the models named Product and added refernece in the ApplicationDbContext added migration and updated the database
20221124131141_addProductToDb     name for Product for migration 

0815 
added [Required] for title , ISBN and author and added migration 
20221124131516_addValidationToProduct   name for vaiation of product 

0826
added a newIproduct and Product Repository files and updated the IuUnitOfWork and UnitOfWork 

0836
added the product Controllers 
added all the view files in te product folder and updated the layout.cshtml and adde a new js file for the product 
updated UnitOfWork with product 

0843
Added the webHostEnvironment 
and its reference in the productControllers file 

0917
added a new productVM in the models folder  and updated the productControllers 
 Added package

 0935
 added content in index.cshtml in product

 1017
 added content in product.js

 1021
 modified width in product.js
 added curly bracked in product.js

 0844
 made few changes in the productcontroller to fix errors 
 added the new upsert file in the product.cs 

 made changes in the product.js 

 added two new folders in the wwwrooot file 
 1) images 
 and subfolder 
 2) products 

 0902
 added data in the home controller .cs in the customer

 0908
 For the part 4 i made changes in the index.cshtml 
for displaying the data for the products 
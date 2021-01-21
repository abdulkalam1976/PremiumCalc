<h2>Project Description</h2>

Member access the web page and provide basic details i.e. Name, Date of Birth, Age, Occupation, Sum Assured and system calculates monthly premiums and displayed on the screen.

<h2>About Platform/ Tools</h2>
ASP.Net Core MVC 5.0, C#, JQuery, Bootstrap

<h2>Development Approach</h2>

1. Created Customer Model class and defined all the properties which is needed

2. Data Annotation and considered the minimum validation on properties

   <p>a) Name: Required, Can not be more than 200 character.</p>
   <p>b) Dob: DateTime, Required.</p>
   <p>c) Age: Required, Range is between 1-120.</p>
   <p>d) Occupation: Choose from list of Occupation.</p>
   <p>e) DeathSumInsured: Required, Numeric input, Range is between 1 and 500000000.</p>
   
3. Implemented Business Logic

   <p>a) When User select a Date of Birth, Age to be calculated automatically. 
      the same time User is free to change Age Just to show calculation purpose and even user deletes Date of Birth, Age will not be deleted.</p>
   <p>b) Upon changing of Age or Occupation or Sum Assured, Premium is to be calculated.</p>

4. Design Consideration

   <p>a) Occupation Data: Created Occupation Class to store fixed data and define a Property IEnumerable<Occupation> in a Customer class so that When Action called 
                       Occupation data gets initialized and used in a dropdown.</p>
                       
                       Future Consideration: WebAPI project should be created to provide all the required data to the system. As in this case we should have 
                       Occupation REST based HTTPGet method.
  
   <p>b) Occupation Rating: Created Dictionary Class to keep Keys and Value pair data as we need to get the Factor based on Selected Occupation related to Rating. 
                       Dictionary performance is good if we have only key and values.</p>
                       
                       Future Consideration: This HTTPGet method would be moved to WebAPI project and instead of getting the data from Dictionary we should directly 
                       retrieve using Entity Framework.
                       
   <p>c) Calculate Premium using JQuery on Browser.</p>


   


<h2>Project Description</h2>

As a Member I would like to have an ability to choose various options on the screen  So that I can view the monthly premiums calculated and displayed on the screen.

<h2>About Platform/ Tools</h2>
ASP.Net Core MVC 5.0, C#, JQuery, Bootstrap

<h2>Development Approach</h2>

<h3>1. Customer Model class created and defined all the required properties</h3>

<h3>2. Used Data Annotation and considered the needed validation</h3>

   <p>a) Name: Required, Can not be more than 200 character.</p>
   <p>b) Dob: DateTime, Required.</p>
   <p>c) Age: Calculated based on Dob</p>
   <p>d) Occupation: Required, Select from list of Occupation.</p>
   <p>e) DeathSumInsured: Required, Numeric input, Range is between 1 and 500000000.</p>
   
<h3>3. Business Logic:</h3>

   <p>a) When User select a Date of Birth, Age to be calculated automatically.</p>
   <p>b) Upon changing of Age or Occupation or Sum Assured, Premium is to be calculated.</p>

<h3>4. Design Consideration:</h3>

   <p><h4>a) Occupation Data: </h4>
                      <table>
                         <th>Occupation</th>
                         <th>Rating</th>
                         <tr>
                            <td>Cleaner</td>
                            <td>Light Manual</td>
                         </tr>
                         <tr>
                            <td>Doctor</td>
                            <td>Professional</td>
                         </tr>
                         <tr>
                            <td>Author</td>
                            <td>White Collar</td>
                         </tr>
                         <tr>
                            <td>Farmer</td>
                            <td>Heavy Manual</td>
                         </tr>
                         <tr>
                            <td>Mechanic</td>
                            <td>Heavy Manual</td>
                         </tr>
                           <tr>
                            <td>Florist</td>
                            <td>Light Manual</td>
                         </tr>
                      </table>
                </p>
                <p>
                       Created Occupation Class to store fixed data and define a Property IEnumerable<Occupation> in a Customer class so that When Action called 
                       Occupation data gets initialized and used in a dropdown.</p>
                       
                       Future Consideration: WebAPI project should be created to provide all the required data to the system. As in this case we should have 
                       Occupation REST based HTTPGet method.
  
   <p><h4>b) Occupation Rating: </h4>
                <table>
                         <th>Rating</th>
                         <th>Factor</th>
                         <tr>
                            <td>Professional</td>
                            <td>1.0</td>
                         </tr>
                         <tr>
                            <td>White Collar</td>
                            <td>1.25</td>
                         </tr>
                         <tr>
                            <td>Light Manual</td>
                            <td>1.5</td>
                         </tr>
                         <tr>
                            <td>Heavy Manual</td>
                            <td>1.75</td>
                         </tr>
                         </table>
                         </p>
                         <p>
                       Created Dictionary Class to keep Keys and Value pair data as we need to get the Factor based on Selected Occupation related to Rating. 
                       Dictionary performance is good if we have only key and values.</p>
                       
                       Future Consideration: This HTTPGet method would be moved to WebAPI project and instead of getting the data from Dictionary we should directly 
                       retrieve using Entity Framework.
                       
   <p><h4>c) Calculated Premium using the below formula</h4>
        <h5>
         Death Premium = (Death Cover amount * Occupation Rating Factor * Age) /1000 * 12
        </h5>         
         The Calculation is done using Jquery on Browser side.
   </p>

   <p><h4>d) Submit & Refresh</h4>
         Checks the Validity of Model and Clear data
   </p>

<h2>Output Screen</h2>
<p>
<a href="https://github.com/abdulkalam1976/MyPremium/blob/master/p1.JPG" target="_blank">
  Starting Index Page
</a>
</p>
<p>
<a href="https://github.com/abdulkalam1976/MyPremium/blob/master/p2.JPG" target="_blank">
  Validation Page
</a>
   </p>
   <p>
<a href="https://github.com/abdulkalam1976/MyPremium/blob/master/p3.JPG" target="_blank">
  Output Page
</a>
   </p>

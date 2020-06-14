# Rats in the Restaurants

## Project Overview
Health inspections occur for the safety of the public to keep restaurants up to date with health codes. Health violations such as rats found in restaurants is one type of violation code that would lower the grade of the restaurant. This analysis will help determine which restaurants are prone to more health violations, based on location in Los Angeles County.

## Resources
1) Los Angeles County Open Source
- Inspections: https://data.lacounty.gov/Health/LOS-ANGELES-COUNTY-RESTAURANT-AND-MARKET-INSPECTIO/6ni6-h5kp
- Violations: https://data.lacounty.gov/Health/LOS-ANGELES-COUNTY-RESTAURANT-AND-MARKET-VIOLATION/8jyd-4pv9
- Health Community: https://data.lacounty.gov/Health/Los-Angeles-County-City-and-Community-Health-Profi/capb-kusk

2) Google Slides
- https://docs.google.com/presentation/d/1fONfWnvPUPYfaIGxkxsvcScwwaHlTBpz2CZawL7Ysrw/edit?usp=sharing

3) Software
- Software/Toolkit: Visual Studio Code 1.39.0, Jupyter Notebook 6.0.3, SQLAlchemy 1.3.9, PostgresSQL
- Languages: Python 3.7
- Machine Learning Libraries: SciKitLearn

4) Communication
- Team 5 is meeting 3-4 times a week to discuss and work on the project
    - Square Role: Esther
    - Triangle Role: Maria
    - Circle Role: Julie
    - X Role: Daniela
    - $ Role: Dustin
- Although roles were given based on shape, each member shared all roles and worked on together throughout the project(TEAMWORK)
- Primarily use Zoom, Slack, MIRO (to keep on track), and GitHub 

## ETL
1) EXTRACT
- Extracted datasets(inspections, violations, and health community) as CSV from Los Angeles County Open Source

2) TRANSFORM
- Data Cleaning and Analysis
    - Pandas will be used to clean the data and perform an exploratory analysis. Further analysis will be completed using Python.
    - Filled in missing data
    - Normalized data

3) LOAD 
- Database Storage
    - PostgreSQL is the database we intend to use, and we will integrate SQLalchemy to connect back to Jupyter Notebook.

## SQL
- In SQL, we merged inspection.csv(public.inspection2) and violation.csv to create a final dataset.  Within the dataset, Facility_City names were replaced (i.e. "Malibu" to "Santa Monica") to correlate with closest distance to cities that were already placed in the inspection.csv.  

<img width=“400” alt=“” src="https://github.com/mcarter-00/Rats-in-the-Restaurants/blob/master/SQL_Screenshots/Screenshot_Joined_Table_SQL.png"> 


### ERD
Between public.inspection2 and violations, our primary key is "serial_number."  That was used to merge the two datasets.

<img width=“400” alt=“” src="https://github.com/mcarter-00/Rats-in-the-Restaurants/blob/master/ERD.png"> 

## Machine Learning
- Machine Learning
    - Used multiple machine learning (i.e. PCA, SVM, SVC, Linear Regression) and finalized with Random Forest as it processed the best results(65% accuracy compared to 8% with SVC)
    
    Random Forest Model
    <img width=“400” alt=“” src="https://github.com/mcarter-00/Rats-in-the-Restaurants/blob/Esther-Branch/ML_Screenshots/Random_Forest.png"> 

    SVC Model  
    <img width=“400” alt=“” src="https://github.com/mcarter-00/Rats-in-the-Restaurants/blob/master/ML_Screenshots/LinearSVC_ML_Results.png"> 

### Description of preliminary data preprocessing 
We took several data transformation and preprocessing steps upon continuous data exploration and analysis. They were broken down into the following parts.

    Part one of the data preprocessing included:
        * abstracting only restaurants, coordinates, and seats numbers
        * dropping unwanted columns, renaming kept columns
        * changing data types
        * replacing null values with appropiate values
    Part two of the data preprocessing included:
        * replacing missed null values
        * dropping unwated columns
    Part three of the data preprocessing included:
        * modifying "Activity Date" to include "MONTH-YEAR" and "MONTH" columns
        * creating a new column from 'SEATS' into 'new_seats' that represents "seat bins"
        * dropping unwated columns
    Part four of the data preprocessing included:
        * setting facility city = "Los Angeles, City of"
        * dropping columns consisting of categorical data

### Description of preliminary feature engineering and preliminary feature selection, including their decision-making process
We conducted linear regression analysis to assess a restaurant's "score" versus each potential feature selection (n=43). The analysis
included determining p-values and r-values to better understand significance and correlations among our data. This process helped
inform our feature selection. 

### Description of how data was split into training and testing sets
We attempted to use an linear SVC model where we selected our y-values to be "SCORE" and x-values to be the remaining numerical 
features (n=43). We separated our data into training and testing set that included the parameters:
    * random state = 42  
    * stratisfy = "Y"

### Explanation of model choice, including limitations and benefits
The linear SVC model presented several limitations. Running our model took a couple of hours to complete, and it resulted in a very 
low accuracy score (about 6%). Upon discussing and re-evaluting our model, we decided on reducing our feature selections to about handful
based on the highest r-values from our linear regression analysis and limiting restaurants to Los Angeles city only. We tested this approach
on a random forest model, which still procuded a low accuracy score. We reverted back to keeping all our feature selections and keeping all
cities in Los Angeles County. Our random forest model then produced an accuracy score of about 70%.

## Dashboard

Tableau is used for data visualization. 
1) The first bar chart displays inspections vs city, with Los Angeles, City Of to have the most health violations per serial number. 
2) The second bar chart displays inspections per facility.  Facilities that are presented are large chain restaurants and Subway has the most health violations in the Los Angeles County.  
3) The third chart represents the amount of inspections per city of the specific program name (chain restaurant).
<img width=“400” alt=“” src="https://github.com/mcarter-00/Rats-in-the-Restaurants/blob/master/Dashboard%20prints/Screen%20Shot%202020-06-14%20at%2012.03.30%20AM.png"> 

4) A heat map was generated to display the regions per zipcode the average grades of restaurants.
<img width=“400” alt=“” src="https://github.com/mcarter-00/Rats-in-the-Restaurants/blob/master/Dashboard%20prints/Screen%20Shot%202020-06-14%20at%2012.05.13%20AM.png">

5) A tile chart displays health violations that are marked the most during health inspections. #44 Floors, wall,... is the highest marked violation.
<img width=“400” alt=“” src="https://github.com/mcarter-00/Rats-in-the-Restaurants/blob/master/Dashboard%20prints/Screen%20Shot%202020-06-14%20at%2012.05.55%20AM.png"> 
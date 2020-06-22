# Rats in the Restaurants

## Project Overview
Health inspections occur for the safety of the public to keep restaurants up to date with health codes. Health violations such as rats found in restaurants is one type of violation code that would lower the grade of the restaurant. This analysis will help determine which restaurants are prone to more health violations, based on location in Los Angeles County.

## Resources
1) Los Angeles County Open Source
- [Inspections Dataset](https://data.lacounty.gov/Health/LOS-ANGELES-COUNTY-RESTAURANT-AND-MARKET-INSPECTIO/6ni6-h5kp)
- [Violations Dataset](https://data.lacounty.gov/Health/)LOS-ANGELES-COUNTY-RESTAURANT-AND-MARKET-VIOLATION/8jyd-4pv9
- [Health Community Dataset](https://data.lacounty.gov/Health/Los-Angeles-County-City-and-Community-Health-Profi/capb-kusk)

2) Google Slides
- [Link](https://docs.google.com/presentation/d/1fONfWnvPUPYfaIGxkxsvcScwwaHlTBpz2CZawL7Ysrw/edit?usp=sharing)

3) Tableau Interactive Map
- [Link](https://public.tableau.com/profile/danigio#!/vizhome/Rats_interactivedashboard_2/RestaurantsinLAwithviolations)

4) Tableau Dashboard
- [Link](https://public.tableau.com/profile/esther.kim4056#!/vizhome/Rats-in-the-RestaurantsHealthViolations/HealthViolationsperCity)

5) Software
- Software/Toolkit: Visual Studio Code 1.39.0, Jupyter Notebook 6.0.3, SQLAlchemy 1.39,PostgresSQL
- Languages: Python 3.7
- Machine Learning Libraries: SciKitLearn

## ETL
1) EXTRACT
- Extracted from Los Angeles County’s open data portal
- Filtered to compare urban and suburban cities within Los Angeles County
- Evaluated possible correlations between health violations, venue size, community health demographics
- Explored if marijuana, alcohol consumption, and crime rate affect health violations



2) TRANSFORM
- Extricated 1,000,000 rows and nearly 1,000 columns of feature rich and machine learning ready utilizing 6 programming libraries to munge, normalize, split and encode drawing from Los Angeles city and county publicly available information


3) LOAD 
- Loaded two data frames into tables using PostgreSQL
- Normalized data in SQL
- Joined tables and exported to .CSV for Machine Learning*
- The reliability and easy accessibility is one of SQL’s main fortes, assuring the clean join for the machine learning phase


## SQL
- In SQL, we merged inspection.csv(public.inspection2) and violation.csv to create a final dataset.  Within the dataset, Facility_City names were replaced (i.e. "Malibu" to "Santa Monica") to correlate with closest distance to cities that were already placed in the inspection.csv.  

<img width=“150” alt=“” src="https://github.com/mcarter-00/Rats-in-the-Restaurants/blob/master/Database/SQL_Screenshots/Screenshot_Joined_Table_SQL.png"> 


## ERD
Between public.inspection2 and violations, our primary key is "serial_number."  That was used to merge the two datasets.

<img width=“150” alt=“” src="https://github.com/mcarter-00/Rats-in-the-Restaurants/blob/master/Database/ERD.png"> 

## Machine Learning
- Machine Learning
    - Used multiple machine learning (i.e. PCA, SVM, SVC, Linear Regression) and finalized with Random Forest as it processed the best results(67% accuracy compared to 8% with SVC)
    
    Random Forest Model
    <img width=“150” alt=“” src="https://github.com/mcarter-00/Rats-in-the-Restaurants/blob/master/Machine_Learning/ML_Screenshots/Random_Forest.png"> 

    SVC Model  
    <img width=“150” alt=“” src="https://github.com/mcarter-00/Rats-in-the-Restaurants/blob/master/Machine_Learning/ML_Screenshots/LinearSVC_ML_Results.png"> 

### Description of Preliminary Data Preprocessing 
We took several data transformation and preprocessing steps upon continuous data exploration and analysis. They were broken down into the following parts.

    Part one of the data preprocessing included:
        * abstracting only restaurants, coordinates, and seats numbers
        * dropping unwanted columns, renaming kept columns
        * changing data types
        * replacing null values with appropriate values
    Part two of the data preprocessing included:
        * replacing missed null values
        * dropping unwanted columns
    Part three of the data preprocessing included:
        * modifying "Activity Date" to include "MONTH-YEAR" and "MONTH" columns
        * creating a new column from 'SEATS' into 'new_seats' that represents "seat bins"
        * dropping unwanted columns
    Part four of the data preprocessing included:
        * setting facility city = "Los Angeles, City of"
        * dropping columns consisting of categorical data

### Description of preliminary feature engineering and preliminary feature selection, including their decision-making process
We conducted linear regression analysis to assess a restaurant's "score" versus each potential feature selection (n=43. The analysis included determining p-values and r-values to better understand significance and correlations among our data. This process helped inform our feature selection. 

### Description of how data was split into training and testing sets
Our data was defined as:
x = One of the 43 features 
    [X = rats2_ml_df.copy()]
    [X = X.drop("SCORE", axis=1)]
y = "SCORE" 
    [y = rats2_ml_df["SCORE"].ravel()]

We separated our data into training and testing sets that included the the parameters:
    * X_train, X_test, y_train, y_test = train_test_split(X, y, random_state=78)

### Explanation of model choice, including limitations and benefits
The linear SVC model presented several limitations. Running our model took a couple of hours to complete, and it resulted in a very low accuracy score (about 6%). Upon discussing and re-evaluting our model, we decided on reducing our feature selections to about handful based on the strongest r-values from our linear regression analysis and limiting restaurants to Los Angeles city only. We tested this approach on a random forest model, which still procuded a low accuracy score. We reverted back to keeping all our feature selections and keeping all cities in Los Angeles County. Our random forest classifier included two parameters: n_estimators = 200 and random_state =78. Finally, our random forest model then produced an accuracy score of about 70%. Feature importance was calculated and sorted. It revealed that “LAT”, “LNG”, and “FACILITY_ZIP” were among the top. Although not strong, it still demonstrates an impact.

## Dashboard

Tableau is used for data visualization. 
1) A dashboard that displays the importance level per health violation, city with most health violation, and grades given to restaurant per health violation from the initial analysis.
<img width=“150” alt=“” src="https://github.com/mcarter-00/Rats-in-the-Restaurants/blob/master/Data_Visualization/Dashboard%20prints/Health_violations_per_city.png"> 

2) An interactive dashboard that displays restaurants if selecting restaurant name, grade, size, and/or health violation.
<img width=“150” alt=“” src="https://github.com/mcarter-00/Rats-in-the-Restaurants/blob/master/Data_Visualization/Dashboard%20prints/Interaction_dashboard.png"> 

3) A dashboard that represents the importance level per feature from machine learning.
<img width=“150” alt=“” src="https://github.com/mcarter-00/Rats-in-the-Restaurants/blob/master/Data_Visualization/Dashboard%20prints/Level_of_importance.png"> 

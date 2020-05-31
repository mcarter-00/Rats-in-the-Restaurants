
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

## ETL
1) Extract
- Extracted datasets(inspections, violations, and health community) as CSV from Los Angeles County Open Source

2) Transform
- Data Cleaning and Analysis
    - Pandas will be used to clean the data and perform an exploratory analysis. Further analysis will be completed using Python.
    - Filled
- Database Storage
PostgresSQL is the database we intend to use, and we will integrate SQLalchemy to connect back to Jupyter Notebook.
- Machine Learning
SciKitLearn is the ML library we'll be using to create a classifier. 

ML steps: 
1) Confirm there are no null value or duplicated value in data set
2) Separate the features from the target
3) Convert string from feature columns to numerical, if necessary (encoding)
4) Split the data into training and testing
5) Build classifier/model - Our training and testing setup will be Linear Regression
6) Fit the model 
7) Generate predictions 
8) Plot predictions
9) Examine the model 


Output data (target): 
- Score

Input data (Features):
- Location
- Number of seats in a Restaurant
- Additional Demographic information per cities and communities in Los Angeles County:
    - Total population (Pop_Tot)
    - Proportion of residents ages 17 years and younger (Prop_18y)
    - Proportion of residents ages 18-64 years (Prop_64y)
    - Proportion of residents ages 65 years and older (Prop_65y+)
    - Proportion of black residents (Prop_Blk)
    - Proportion of Latino residents (Prop_Lat)
    - Proportion of white residents (Prop_Whi)
    - Proportion of Asian residents (Prop_Asi)
    - Proportion of American Indian or Alaska Native residents (Prop_Ami)
    - Proportion of Native Hawaiian or other Pacific Islander residents (Prop_NHO)
    - Proportion of residents living below 100% Federal Poverty Level (Prop_FPL1)
    - Proportion of residents living below 200% Federal Poverty Level (Prop_FPL2)
    - Proportion of foreign-born residents (Prop_forb)
    - Proportion of households with Limited English Proficiency (Prop_Eng)
    - Proportion of adults (ages 25 years and older) with less than a high school education (Prop_edLH)
    - Proportion of adults (ages 25 years and older) who are high school graduates (Prop_edHG)
    - Proportion of adults (ages 25 years and older) with some college education (Prop_edSC)
    - Proportion of adults (ages 25 years and older) with a bachelor's degree or higher (Prop_edCG)
    - Median household income (MHI)
    - Proportion of the population living in close proximity to a supermarket or grocery store (Prop_groc)
    - Proportion of working population (ages 16 years and older) with one-way commute to work of 60 minutes or longer (Prop_60mi)
    - Number of farmers' markets (No_farm)
    - Proportion of adults (ages 18 years and older) who are obese (Prop_obse)
    - Proportion of adults (ages 18 years and older) with diagnosed diabetes (Prop_DM)
    - Cardiovascular disease deaths (per 100,000 population) (Rte_CVD)
    - Proportion of households that own their homes (Prop_ownr)
    - Proportion of households that rent (Prop_rentr)
    - Estimated number of homeless individuals (No_hless)
    - Serious crimes (per 100,000 population) (Rte_crim)
    - Alcohol outlets (per 10,000 population) (Prop_alco)
    - California Healthy Places Index Clean Environment Score rank percentile (Prop_envi)
    - Proportion of adults (>18 years) with diagnosed depression (Prop_depr)
    - California Healthy Places Index (HPI) Score rank percentile (Propt_HPI)
    - Proportion of adults (> 18 years) meeting fruits & vegetables recommendations (Prop_fru)
    - Proportion of children (< 17 years) reporting daily consumption of sugar sweetened beverages (Prop_bev
    - Proportion of adults (ages 18 years and older) with diagnosed hypertension (Prop_hyp)
    - Proportion of adults (> 18 years) who used marijuana (Prop_marj)


## Dashboard
In addition to using Tableau for a fully functioning and interactive dashboard; tableau public server will be used to share it.
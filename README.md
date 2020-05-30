# Rats-in-the-Restaurants

Week 1 Assignment

1. Download csv files into ipynb file
2. Inspect the data (exploratory analysis)

3. Present a provisional database that stands in for the final database and accomplishes the following:
✓ Sample data that mimics the expected final database structure or schema
✓ Draft machine learning module is connected to the provisional database

QUESTIONS FOR TUESDAY, 5/26 RECOMMENDED CLASS

Week 1 Rubric

1.	What is the meaning of “Description of the communication protocols”?
Answer: Slack, Zoom, GitHub, README, Miro project management tool.

2.	What is the meaning of “Outputs label(s) for input data”?
Answer: Features (input) and Target (output).

3.	Number of commits.  We figured this question out before class.


Week 2 Rubric

4.	Is “data exploration phase” the same as “inspect the data”?
Answer: No, it is more than that.  It is “EDA”, like in the modules. inspect, clean the data.

### Cleaning the Data


We deleted columns from the Inspections dataframe and the Community Health dataframe that had “noise”, data that was either not relevant or was not a value add as the headers and values had no definition.


Data clean up on the Facility_City and GEONAME columns in order to merge the community health dataframe to the dataframe that is the merging of the inspections and violations data frames.

  - We changed the GEONAME column in the Community Health to all upper case so it would be the same case as the values in the Facility_City column in the Inspections & Violations dataframe.

	- We reviewed the actual location of each city listed to determine if some location names could be assigned to a a location name in the other dataframe so each dataframe would have the same exact names as this is the column of unique values we are going to merge the two on.  We used a radius of 15 miles to group locations into a location that matched the other dataframe.


The activity_date column in the Inspections dataframe was changed to date datatype.

The location column in the Inspections dataframe was split to extract the longitude and latitude for use in mapping locations.

The pe_description column in the Inspections dataframe was split and create new columns with the split data in order to isolate the Number of Seats, a feature that we absolutely wanted.



# Rats-in-the-Restaurants

#exploring dataset...
1) import dataset and create a dataframe (210427 rows × 20 columns)
2) loop through each column, check if there are null values
  *  only 2 columns had nulls:
  *  Column GRADE has 77 null values
  *  Column Location has 7106 null values
3) PE DESCRIPTION options: 
* CATERER (0-999 SQ. FT.)', 'CATERER (1,000-1,999 SQ. FT.)',
*       'FOOD MARKET WHOLESALE', 'FOOD MKT RETAIL (1-1,999 SF) HIGH RISK',
*       'FOOD MKT RETAIL (1-1,999 SF) LOW RISK',
*       'FOOD MKT RETAIL (1-1,999 SF) MODERATE RISK',
*       'FOOD MKT RETAIL (2,000+ SF) HIGH RISK',
*       'FOOD MKT RETAIL (2,000+ SF) LOW RISK',
*       'FOOD MKT RETAIL (2,000+ SF) MODERATE RISK',
*       'FOOD PROCESSING WHOLESALE (1-1,999 SQ. FT.)',
*       'FOOD PROCESSING WHOLESALE (2,000-5,999 SF)',
*       'FOOD PROCESSING WHOLESALE (6,000 + SQ. FT.)',
*       'FOOD VEHICLE COMMISSARY (0-10)', 'FOOD WAREHOUSE (1-4,999) SQ. FT.',
*       'INTERIM HOUSING FF (1-1,999) SQ. FT.',
*       'INTERIM HOUSING FF (2,000-4,999) SQ. FT.',
*       'LIC HTH CARE FOOD FAC (0-1999 SF) HIGH RISK',
*       'LIC HTH CARE FOOD FAC (0-1999 SF) MOD RISK',
*       'LIC HTH CARE FOOD FAC (10,000+ SF) HIGH RISK',
*       'LIC HTH CARE FOOD FAC (2000-3999 SF)HIGH RISK',
*       'LIC HTH CARE FOOD FAC (4000-9999 SF)HIGH RISK',
*       'PRIVATE SCHOOL CAFETERIA', 'RESTAURANT (0-30) SEATS HIGH RISK',
*       'RESTAURANT (0-30) SEATS LOW RISK',
*       'RESTAURANT (0-30) SEATS MODERATE RISK',
*       'RESTAURANT (151 + ) SEATS HIGH RISK',
*       'RESTAURANT (151 + ) SEATS LOW RISK',
*       'RESTAURANT (151 + ) SEATS MODERATE RISK',
*       'RESTAURANT (31-60) SEATS HIGH RISK',
*       'RESTAURANT (31-60) SEATS LOW RISK',
*       'RESTAURANT (31-60) SEATS MODERATE RISK',
*       'RESTAURANT (61-150) SEATS HIGH RISK',
*       'RESTAURANT (61-150) SEATS LOW RISK',
*      'RESTAURANT (61-150) SEATS MODERATE RISK'],

4) Remove all the ones that are not classified as restaurants 171862 rows × 20 columns

5) Removed the columns: Owner name, Employee id

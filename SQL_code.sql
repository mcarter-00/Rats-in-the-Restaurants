CREATE TABLE inspection2 as (SELECT * FROM clean_inspections);
UPDATE inspection2 
SET 
    "FACILITY_CITY" = LOWER("FACILITY_CITY");
Update inspection2 Set 
facility_city = REPLACE(facility_city,'AGOURA', 'Calabasas');
Update inspection2 Set 
"FACILITY_CITY" = REPLACE("FACILITY_CITY",'AGOURA HILLS', 'Calabasas');
Update inspection2 Set 
"FACILITY_CITY" = REPLACE("FACILITY_CITY",'ARLETA', 'San Fernando');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'EL SERENO', 'Alhambra');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'SIERRA MADRE', 'Arcadia');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'IRWINDALE', 'Baldwin Park');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'CENTURY CITY', 'Beverly Hills');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'WESTWOOD', 'Beverly Hills');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'NORTH HOLLYWOOD', 'Burbank');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'SHADOW HILLS', 'Burbank');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'STUDIO CITY', 'Burbank');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'SUN VALLEY', 'Burbank');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'TOLUCA LAKE', 'Burbank');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'UNIVERSAL CITY', 'Burbank');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'VALLEY GLEN', 'Burbank');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'VALLEY VILLAGE', 'Burbank');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'CANOGA PARK', 'Calabasas');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'CHATSOWRTH', 'Calabasas');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'CHATSWORTH', 'Calabasas');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'ENCINO', 'Calabasas');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'LAKE BALBOA', 'Calabasas');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'RESEDA', 'Calabasas');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'TARZANA', 'Calabasas');Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'WEST HILLS', 'Calabasas');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'WESTLAKE VILLAGE', 'Calabasas');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'WINNETKA', 'Calabasas');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'HARBOR CITY', 'Calabasas');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'WOODLAND HILLS', 'Carson');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'SAN PEDRO', 'Carson');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'TERMINAL ISLAND', 'Carson');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'WILMINGTON', 'Carson');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'ARTESIA', 'Cerritos');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'HAWAIIAN GARDENS', 'Cerritos');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'RANCHO DOMINGUEZ', 'Compton');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'CITY OF INDUSTRY', 'Covina');Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'PLAYA VISTA', 'Culver City');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'CITY TERRACE', 'East Los Angeles');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'COMMERCE', 'East Los Angeles');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'SOUTH EL MONTE', 'El Monte');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'EAGLE ROCK', 'Glendale');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'LA CRESCENTA', 'Glendale');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'LA HABRA HEIGHTS', 'Hacienda Heights');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'LENNOX', 'Hawthorne');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'VERNON', 'Huntington Park');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'WALNUT PARK', 'Huntington Park');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'PLAYA DEL REY', 'Inglewood');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'WESTCHESTER', 'Inglewood');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'SIGNAL HILL', 'Lakewood');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'LEONA VALLEY', 'Lancaster');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'QUARTZ HILL', 'Lancaster');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'LINCOLN HEIGHTS', 'Los Angeles, City of');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'LOS ANGELES', 'Los Angeles, City of');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'EL SEGUNDO', 'Manhattan Beach');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'DUARTE', 'Monrovia');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'SANTA FE SPRINGS', 'Norwalk');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'LITTLEROCK', 'Palmdale');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'LA CANADA FLINTRIDGE', 'Pasadena');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'MONTROSE', 'Pasadena');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'PALOS VERDES ESTATES', 'Rancho Palos Verdes');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'PALOS VERDES PENINSULA', 'Rancho Palos Verdes');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'RANCHOS PALOS VERDES', 'Rancho Palos Verdes');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'ROLLING HILL ESTATES', 'Rancho Palos Verdes');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'ROLLING HILLS', 'Rancho Palos Verdes');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'ROLLING HILLS ESTATES', 'Rancho Palos Verdes');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'HERMOSA BEACH', 'Redondo Beach');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'ARLETA', 'San Fernando');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'GRANADA HILLS', 'San Fernando');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'LAKE VIEW TERRACE', 'San Fernando');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'MISSION HILLS', 'San Fernando');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'NORTH HILLS', 'San Fernando');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'NORTHRIDGE', 'San Fernando');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'PACOIMA', 'San Fernando');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'PANORAMA CITY', 'San Fernando');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'PORTER RANCH', 'San Fernando');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'SEPULVEDA', 'San Fernando');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'SHERMAN OAKS', 'San Fernando');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'SUNLAND', 'San Fernando');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'SYLMAR', 'San Fernando');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'TUJUNGA', 'San Fernando');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'VAN NUYS', 'San Fernando');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'CANYON COUNTRY', 'Santa Clarita');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'CASTAIC', 'Santa Clarita');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'NEW HALL', 'Santa Clarita');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'NEWHALL', 'Santa Clarita');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'SAUGUS', 'Santa Clarita');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'STEVENSON RANCH', 'Santa Clarita');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'VALENCIA', 'Santa Clarita');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'MALIBU', 'Santa Monica');Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'MARINA DEL REY', 'Santa Monica');Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'PACIFIC PALISADES', 'Santa Monica');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'VENICE', 'Santa Monica');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'WEST LOS ANGELES', 'Santa Monica');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'SAN MARINO', 'South Pasadena');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'LOMITA', 'Torrance');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'INDUSTRY', 'West Covina');
Update inspection2 Set 
"FACILITY CITY" = REPLACE("FACILITY CITY",'HOLLYWOOD', 'West Hollywood');
DELETE FROM inspection2
WHERE "FACILITY CITY" = 'ACTON' or "FACILITY CITY" = 'AGUA DULCE' or "FACILITY CITY" = 'AVALON' or "FACILITY CITY" = 'GORMAN' or "FACILITY CITY" = 'GREEN VALLEY' or "FACILITY CITY" = 'LAKE HUGHES' or "FACILITY CITY" = 'LAKE LOS ANGELES' or "FACILITY CITY" = 'LEBEC' or "FACILITY CITY" = 'LLANO' or "FACILITY CITY" = 'MOUNT WILSON' or "FACILITY CITY" = 'PEARBLOSSOM' or "FACILITY CITY" = 'VALYERMO' or "FACILITY CITY" = 'WRIGHTWOOD';

SELECT *, REPLACE ("FACILITY_CITY",'AGOURA', 'cat') FROM inspection2;
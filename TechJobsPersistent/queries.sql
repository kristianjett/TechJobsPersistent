--Part 1

SELECT
  COLUMN_NAME, DATA_TYPE 
FROM
  INFORMATION_SCHEMA.COLUMNS 
WHERE
  TABLE_SCHEMA = 'techjobs'
AND
  TABLE_NAME = 'jobs';

--Part 2

SELECT name
FROM employers
Where (Location LIKE 'St. Louis');

--Part 3


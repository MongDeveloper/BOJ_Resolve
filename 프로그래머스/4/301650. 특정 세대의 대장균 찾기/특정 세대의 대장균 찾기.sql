SELECT C.ID
FROM ECOLI_DATA AS C
JOIN ECOLI_DATA AS B ON (C.PARENT_ID = B.ID)
JOIN ECOLI_DATA AS A ON (B.PARENT_ID = A.ID)
WHERE A.PARENT_ID IS NULL
ORDER BY C.ID
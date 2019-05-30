USE [GutenbergDB]
GO

/****** Object: Table [dbo].[Cities] Script Date: 27-05-2019 16:03:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

bulk insert Cities
from 'C:\Users\Mohammad Saad\Desktop\try\root\worldcities.csv' 
with
(  
FIRSTROW = 2,
    FIELDTERMINATOR = ';',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
	)




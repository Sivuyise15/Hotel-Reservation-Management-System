CREATE TABLE [dbo].[Resarvation]
(
	[ID]     NVARCHAR (15)  NOT NULL,
    [ResarvationID]  NVARCHAR (10)  NOT NULL,
    [GuestID]   NVARCHAR (15) NOT NULL,
    [RoomID]  NVARCHAR (15) NOT NULL,
    [CheckInDate]  DATE NOT NULL,
    [CheckOutDate] DATE NOT  NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)

);

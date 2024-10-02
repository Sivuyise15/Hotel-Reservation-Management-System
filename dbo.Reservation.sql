CREATE TABLE [dbo].[Reservation] (
    [ReservationID]        NVARCHAR (20)  NOT NULL,
    [GuestID]              NVARCHAR (20)  NOT NULL,
    [RoomID]               NVARCHAR (20)  NOT NULL,
    [CheckInDate]          DATE           NOT NULL,
    [CheckOutDate]         DATE           NOT NULL,
    [SpecialRequests]      NVARCHAR (300) NOT NULL,
    [ReservationTotalCost] MONEY          NULL,
    PRIMARY KEY CLUSTERED ([ReservationID] ASC)
);


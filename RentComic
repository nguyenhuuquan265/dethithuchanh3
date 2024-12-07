CREATE PROCEDURE RentComic
    @UserId INT,
    @ComicId INT
AS
BEGIN
    DECLARE @AvailableCopies INT;
    
    SELECT @AvailableCopies = AvailableCopies FROM Comics WHERE ComicId = @ComicId;
    
    IF @AvailableCopies > 0
    BEGIN
        INSERT INTO Rentals (UserId, ComicId, RentalDate)
        VALUES (@UserId, @ComicId, GETDATE());
        
        UPDATE Comics
        SET AvailableCopies = AvailableCopies - 1
        WHERE ComicId = @ComicId;
    END
    ELSE
    BEGIN
        RAISERROR('No copies available for rent.', 16, 1);
    END
END;
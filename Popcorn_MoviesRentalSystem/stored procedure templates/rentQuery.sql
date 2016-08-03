-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
-- =============================================
-- Author:		<Bautista,Jaypee>
-- Create date: <July 16, 2016>
-- Description:	<Rent Info insert,update and delete query>
-- =============================================
	-- Add the parameters for the stored procedure here
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE rentQuery
(
	@rent_id varchar(50) = null,
	@movie_id varchar(50) = null,
	@customer_id varchar(50) = null,
	@rent_dateBorrowed  varchar(50) = null,
	@rent_dateReturned varchar(50) = null,
	@rent_daysTotal int = null,
	@rent_rentalFee int = null,
	@rent_penaltyFee int = null,
	@StatementType nvarchar(20) = ''
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF @StatementType = 'Insert'
		BEGIN
			INSERT INTO dbo.tbl_rentMovie
			(
				rent_id, 
				movie_id, 
				customer_id, 
				rent_dateBorrowed, 
				rent_dateReturned, 
				rent_daysTotal, 
				rent_rentalFee, 
				rent_penaltyFee
			)
			VALUES
			(
				@rent_id, 
				@movie_id, 
				@customer_id, 
				@rent_dateBorrowed, 
				@rent_dateReturned, 
				@rent_daysTotal, 
				@rent_rentalFee, 
				@rent_penaltyFee)
		END
	IF @StatementType = 'Update'
		BEGIN
			UPDATE dbo.tbl_rentMovie SET
				movie_id = @movie_id, 
				customer_id = @customer_id, 
				rent_dateBorrowed = @rent_dateBorrowed,
				rent_dateReturned = @rent_dateReturned, 
				rent_daysTotal = @rent_daysTotal, 
				rent_rentalFee = @rent_rentalFee, 
				rent_penaltyFee = @rent_penaltyFee
			WHERE rent_id = @rent_id
		END
	IF @StatementType = 'Delete'
		BEGIN
			DELETE FROM dbo.tbl_rentMovie WHERE rent_id = @rent_id
		END
END
GO

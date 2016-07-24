USE [db_videoRental]
GO
/****** Object:  StoredProcedure [dbo].[rentInfoQuery]    Script Date: 7/19/2016 7:41:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE rentInfoQuery
(
	@movie_id varchar(50) = null,
	@info_rentType varchar(50) = null,
	@info_rentDays varchar(50) = null,
	@info_rentFee  int = null,
	@info_penaltyFee int = null,
	@info_status varchar(50) = null,
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
			INSERT INTO dbo.tbl_movieRentalInfo
			(
				movie_id, 
				info_rentType, 
				info_rentDays, 
				info_rentFee, 
				info_penaltyFee,
				info_status
			)
			VALUES
			(
				@movie_id, 
				@info_rentType, 
				@info_rentDays, 
				@info_rentFee, 
				@info_penaltyFee,
				@info_status
			)
		END
	IF @StatementType = 'Update'
		BEGIN
			UPDATE dbo.tbl_movieRentalInfo SET
				info_rentType = @info_rentType, 
				info_rentDays = @info_rentDays, 
				info_rentFee = @info_rentFee, 
				info_penaltyFee = @info_penaltyFee,
				info_status = @info_status 
			WHERE movie_id = @movie_id
		END
	IF @StatementType = 'Delete'
		BEGIN
			DELETE FROM dbo.tbl_movieRentalInfo WHERE movie_id = @movie_id
		END
END

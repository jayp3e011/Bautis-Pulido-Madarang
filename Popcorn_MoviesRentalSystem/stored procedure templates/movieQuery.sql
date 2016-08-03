USE [db_videoRental]
GO
/****** Object:  StoredProcedure [dbo].[movieQuery]    Script Date: 7/23/2016 7:02:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[movieQuery]
(
	@movie_id varchar(50) = null,
	@movie_title varchar(50) = null,
	@movie_genre varchar(50) = null,
	@movie_rating  int = null,
	@movie_language varchar(50) = null,
	@movie_casts varchar(500) = null,
	@movie_yearReleased varchar(50) = null,
	@movie_image varchar(200) = null,
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
			INSERT INTO dbo.tbl_movies
			(
				movie_id, 
				movie_title, 
				movie_genre, 
				movie_rating, 
				movie_language, 
				movie_casts, 
				movie_yearReleased,
				movie_image
			)
			VALUES
			(
				@movie_id, 
				@movie_title, 
				@movie_genre, 
				@movie_rating, 
				@movie_language, 
				@movie_casts, 
				@movie_yearReleased,
				@movie_image
			)
		END
	IF @StatementType = 'Update'
		BEGIN
			UPDATE dbo.tbl_movies SET
				movie_title = @movie_title, 
				movie_genre = @movie_genre, 
				movie_rating = @movie_rating, 
				movie_language = @movie_language, 
				movie_casts = @movie_casts, 
				movie_yearReleased = @movie_yearReleased,
				movie_image = @movie_image
			WHERE movie_id = @movie_id
		END
	IF @StatementType = 'Delete'
		BEGIN
			DELETE FROM dbo.tbl_movies WHERE movie_id = @movie_id
		END
	IF @StatementType = 'GetMovieImg'
		BEGIN
			SELECT movie_image FROM dbo.tbl_movies WHERE movie_id = @movie_id
		END
	IF @StatementType = 'GetMovieINFO'
		BEGIN
			SELECT movie_title, movie_genre, movie_yearReleased, movie_image FROM dbo.tbl_movies WHERE movie_id = @movie_id
		END
END

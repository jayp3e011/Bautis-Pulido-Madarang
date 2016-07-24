USE [db_videoRental]
GO
/****** Object:  StoredProcedure [dbo].[GetMovieSet]    Script Date: 7/23/2016 7:04:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[GetMovieSet]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
		movie_id,
		movie_title, 
		movie_genre, 
		movie_rating, 
		movie_language, 
		movie_casts, 
		movie_yearReleased,
		movie_image
	FROM dbo.tbl_movies 
	WHERE movie_id NOT IN(SELECT movie_id FROM dbo.tbl_movieRentalInfo)
END	

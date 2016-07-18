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
-- Create date: <July 17, 2016>
-- Description:	<Joning movie ant movie renta info table>
-- =============================================
	-- Add the parameters for the stored procedure here
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE getMovieSet
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
		movie_yearReleased
	FROM dbo.tbl_movies AS movie
	JOIN dbo.tbl_movieRentalInfo 
	AS info ON movie_id = movie_id
END	
GO

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
-- Description:	<Customer insert,update and delete query>
-- =============================================
	-- Add the parameters for the stored procedure here
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE CustomerQuery
(
	@customer_id varchar(50) = null,
	@customer_firstName varchar(50) = null,
	@customer_lastName varchar(50) = null,
	@customer_middleInitial  varchar(1) = null,
	@customer_address varchar(300) = null,
	@customer_emailAdd varchar(50) = null,
	@customer_contactNo varchar(50) = null,
	@customer_status varchar(50),
	@customer_registeredDate varchar(50) = null,
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
			INSERT INTO dbo.tbl_customer
			(
				customer_id, 
				customer_firstName, 
				customer_lastName, 
				customer_middleInitial, 
				customer_address, 
				customer_emailAdd, 
				customer_contactNo, 
				customer_status, 
				customer_registeredDate
			)
			VALUES
			(
				@customer_id, 
				@customer_firstName, 
				@customer_lastName, 
				@customer_middleInitial, 
				@customer_address, 
				@customer_emailAdd, 
				@customer_contactNo, 
				@customer_status, 
				@customer_registeredDate
			)
		END
	IF @StatementType = 'Update'
		BEGIN
			UPDATE dbo.tbl_customer SET
				customer_firstName = @customer_firstName, 
				customer_lastName = @customer_lastName, 
				customer_middleInitial = @customer_middleInitial, 
				customer_address = @customer_address, 
				customer_emailAdd = @customer_emailAdd,
				customer_contactNo = @customer_contactNo, 
				customer_status = @customer_status, 
				customer_registeredDate = @customer_registeredDate 
			WHERE customer_id = @customer_id
		END
	IF @StatementType = 'Delete'
		BEGIN
			DELETE FROM dbo.tbl_customer WHERE customer_id = @customer_id
		END
END
GO

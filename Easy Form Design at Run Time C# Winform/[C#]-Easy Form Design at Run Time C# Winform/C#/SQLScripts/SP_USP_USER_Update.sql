USE [DynamicProject]
GO
/****** Object:  StoredProcedure [dbo].[USP_Item_Update]    Script Date: 04/16/2015 16:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Author      : Shanu                                                                  
-- Create date : 2015-02-05                                                                  
-- Description : To Update Item Master                                                
-- Tables used :  ItemMasters                                                                 
-- Modifier    : Shanu                                                                  
-- Modify date : 2015-02-05                                                                  
-- =============================================                                                                  
-- exec USP_User_Update '',''      
-- =============================================                                                             
Create PROCEDURE [dbo].[USP_User_Update]                                                
   (        
     @USR_ID          VARCHAR(20)     = '',                              
     @User_Name       VARCHAR(100)     = '',  
     @Email           VARCHAR(100)     = '',  
     @Phone           VARCHAR(100)     = '',  
     @Address         VARCHAR(100)     = ''    
      )                                                          
AS                                                                  
BEGIN                  

   UPDATE [UserMasters]   
     SET 
     User_Name=@User_Name,
     Email=@Email,
     Phone=@Phone,
     Address=@Address
     WHERE  
      USR_ID=@USR_ID  
select 'Updated' as 'Result'
END  
USE [DynamicProject]
GO
/****** Object:  StoredProcedure [dbo].[USP_Item_Insert]    Script Date: 04/16/2015 16:03:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Author      : Shanu                                                                  
-- Create date : 2015-02-05                                                                  
-- Description : To Insert Item Master                                                
-- Tables used :  ItemMasters                                                                 
-- Modifier    : Shanu                                                                  
-- Modify date : 2015-02-05                                                                  
-- =============================================                                                                  
-- exec USP_Item_Insert '',''      
-- =============================================                                                             
ALTER PROCEDURE [dbo].[USP_Item_Insert]                                                
   (        
     @Item_Code          VARCHAR(50)     = '',                              
     @Item_Name     VARCHAR(50)     = '',  
     @Price      INT=0 ,  
     @TAX1      INT=0 ,  
     @Discount     INT=0 ,  
     @Description     VARCHAR(50)     = '',  
     @USR_Name     VARCHAR(50)     = ''       
      )                                                          
AS                                                                  
BEGIN                  

   IF NOT EXISTS (SELECT * FROM ItemMasters WHERE Item_Code=@Item_Code and Item_Name=@Item_Name)  
  BEGIN  
  
   INSERT INTO [ItemMasters]     
      ([Item_Code],[Item_Name],[Price],[TAX1],[Discount],[Description],[IN_DATE]  
        ,[IN_USR_ID],[UP_DATE],[UP_USR_ID])  
   VALUES  
        (@Item_Code,@Item_Name,@Price,@TAX1,@Discount,@Description,GETDATE(),@USR_Name  
        ,GETDATE(),@USR_Name)  
      select 'Inserted' as 'Result'
   END
 
END  
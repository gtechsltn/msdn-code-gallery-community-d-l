USE [DynamicProject]
GO
/****** Object:  StoredProcedure [dbo].[USP_Item_Delete]    Script Date: 04/16/2015 16:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Author      : Shanu                                                                  
-- Create date : 2015-02-05                                                                  
-- Description : To Delete Item Master                                                
-- Tables used :  ItemMasters                                                                 
-- Modifier    : Shanu                                                                  
-- Modify date : 2015-02-05                                                                   
-- =============================================                                                                  
-- exec USP_Item_Delete '',''      
-- =============================================                                                             
ALTER PROCEDURE [dbo].[USP_Item_Delete]                                                
   (        
     @Item_Code          VARCHAR(50)     = ''
      )                                                          
AS                                                                  
BEGIN                  

  DELETE FROM [ItemMasters]   
      WHERE  
      Item_Code=@Item_Code    
   
    select 'Deleted' as 'Result'
    
END  
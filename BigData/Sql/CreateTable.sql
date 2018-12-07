IF NOT EXISTS
(
    SELECT 1 FROM [sys].[databases] WHERE [name] = 'TestDB'
)
BEGIN
    CREATE DATABASE [TestDB];
END;

GO
USE TestDB;
IF NOT EXISTS
(
    SELECT * FROM [sys].[all_objects] WHERE [name] = 'product' and type = 'U'
)
BEGIN
    CREATE TABLE [dbo].[product]
(
      [bi_id]                   [BIGINT], 
      [nvc_product_name]        NVARCHAR(64), 
      [nvc_product_description] NVARCHAR(1024)
);
END;
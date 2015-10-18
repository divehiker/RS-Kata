
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 10/18/2015 17:55:07
-- Generated from EDMX file: C:\Visual Studio 2010\Projects\Misc\RS-Kata\RS-Kata\DataEntities.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Sandbox];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CartCartItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CartItems] DROP CONSTRAINT [FK_CartCartItem];
GO
IF OBJECT_ID(N'[dbo].[FK_CartItemItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CartItems] DROP CONSTRAINT [FK_CartItemItem];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemDiscount]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Discounts] DROP CONSTRAINT [FK_ItemDiscount];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Carts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carts];
GO
IF OBJECT_ID(N'[dbo].[Items]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Items];
GO
IF OBJECT_ID(N'[dbo].[Discounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Discounts];
GO
IF OBJECT_ID(N'[dbo].[CartItems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CartItems];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Carts'
CREATE TABLE [dbo].[Carts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TotalCost] float  NOT NULL
);
GO

-- Creating table 'Items'
CREATE TABLE [dbo].[Items] (
    [SKU] nvarchar(max)  NOT NULL,
    [Price] float  NOT NULL,
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Discounts'
CREATE TABLE [dbo].[Discounts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [QtyRequired] int  NOT NULL,
    [DiscountedPrice] float  NOT NULL,
    [ItemId] int  NOT NULL
);
GO

-- Creating table 'CartItems'
CREATE TABLE [dbo].[CartItems] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CartId] int  NOT NULL,
    [ItemQty] int  NOT NULL,
    [Item_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Carts'
ALTER TABLE [dbo].[Carts]
ADD CONSTRAINT [PK_Carts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Items'
ALTER TABLE [dbo].[Items]
ADD CONSTRAINT [PK_Items]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Discounts'
ALTER TABLE [dbo].[Discounts]
ADD CONSTRAINT [PK_Discounts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CartItems'
ALTER TABLE [dbo].[CartItems]
ADD CONSTRAINT [PK_CartItems]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CartId] in table 'CartItems'
ALTER TABLE [dbo].[CartItems]
ADD CONSTRAINT [FK_CartCartItem]
    FOREIGN KEY ([CartId])
    REFERENCES [dbo].[Carts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CartCartItem'
CREATE INDEX [IX_FK_CartCartItem]
ON [dbo].[CartItems]
    ([CartId]);
GO

-- Creating foreign key on [Item_Id] in table 'CartItems'
ALTER TABLE [dbo].[CartItems]
ADD CONSTRAINT [FK_CartItemItem]
    FOREIGN KEY ([Item_Id])
    REFERENCES [dbo].[Items]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CartItemItem'
CREATE INDEX [IX_FK_CartItemItem]
ON [dbo].[CartItems]
    ([Item_Id]);
GO

-- Creating foreign key on [ItemId] in table 'Discounts'
ALTER TABLE [dbo].[Discounts]
ADD CONSTRAINT [FK_ItemDiscount]
    FOREIGN KEY ([ItemId])
    REFERENCES [dbo].[Items]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemDiscount'
CREATE INDEX [IX_FK_ItemDiscount]
ON [dbo].[Discounts]
    ([ItemId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------

-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/30/2020 19:38:25
-- Generated from EDMX file: C:\Users\Tudor\Documents\FACULTATE\Anul 3\Semestrul2\TSP.NET\MyPhotos\MyPhotos\Photo.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyPhotos];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_dbo_PersonPhotoes_dbo_People_Person_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonPhotoes] DROP CONSTRAINT [FK_dbo_PersonPhotoes_dbo_People_Person_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_PersonPhotoes_dbo_Photos_Photo_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonPhotoes] DROP CONSTRAINT [FK_dbo_PersonPhotoes_dbo_Photos_Photo_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_PhotoCustomFilters_dbo_CustomFilters_CustomFilter_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhotoCustomFilters] DROP CONSTRAINT [FK_dbo_PhotoCustomFilters_dbo_CustomFilters_CustomFilter_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_PhotoCustomFilters_dbo_Photos_Photo_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhotoCustomFilters] DROP CONSTRAINT [FK_dbo_PhotoCustomFilters_dbo_Photos_Photo_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Photos_dbo_Events_EventId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Photos] DROP CONSTRAINT [FK_dbo_Photos_dbo_Events_EventId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Photos_dbo_Landscapes_LandscapeId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Photos] DROP CONSTRAINT [FK_dbo_Photos_dbo_Landscapes_LandscapeId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Photos_dbo_Locations_LocationId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Photos] DROP CONSTRAINT [FK_dbo_Photos_dbo_Locations_LocationId];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CustomFilters]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CustomFilters];
GO
IF OBJECT_ID(N'[dbo].[Events]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Events];
GO
IF OBJECT_ID(N'[dbo].[Landscapes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Landscapes];
GO
IF OBJECT_ID(N'[dbo].[Locations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Locations];
GO
IF OBJECT_ID(N'[dbo].[People]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People];
GO
IF OBJECT_ID(N'[dbo].[PersonPhotoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonPhotoes];
GO
IF OBJECT_ID(N'[dbo].[PhotoCustomFilters]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PhotoCustomFilters];
GO
IF OBJECT_ID(N'[dbo].[Photos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Photos];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CustomFilters'
CREATE TABLE [dbo].[CustomFilters] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CustomFilterName] nvarchar(max)  NULL,
    [CustomFilterDescription] nvarchar(max)  NULL
);
GO

-- Creating table 'Events'
CREATE TABLE [dbo].[Events] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EventName] nvarchar(max)  NULL,
    [EventDescription] nvarchar(max)  NULL
);
GO

-- Creating table 'Landscapes'
CREATE TABLE [dbo].[Landscapes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LandScapeName] nvarchar(max)  NULL,
    [LandScapeDescription] nvarchar(max)  NULL,
    [LandScapeType] nvarchar(max)  NULL
);
GO

-- Creating table 'Locations'
CREATE TABLE [dbo].[Locations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LocationName] nvarchar(max)  NULL,
    [LocationDescription] nvarchar(max)  NULL,
    [LocationType] nvarchar(max)  NULL
);
GO

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NULL,
    [LastName] nvarchar(max)  NULL,
    [Age] nvarchar(max)  NULL
);
GO

-- Creating table 'Photos'
CREATE TABLE [dbo].[Photos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FullPath] nvarchar(max)  NULL,
    [isMovie] nvarchar(max)  NULL,
    [isRemoved] nvarchar(max)  NULL,
    [LandscapeId] int  NOT NULL,
    [EventId] int  NOT NULL,
    [LocationId] int  NOT NULL
);
GO

-- Creating table 'PersonPhotoes'
CREATE TABLE [dbo].[PersonPhotoes] (
    [People_Id] int  NOT NULL,
    [Photos_Id] int  NOT NULL
);
GO

-- Creating table 'PhotoCustomFilters'
CREATE TABLE [dbo].[PhotoCustomFilters] (
    [CustomFilters_Id] int  NOT NULL,
    [Photos_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CustomFilters'
ALTER TABLE [dbo].[CustomFilters]
ADD CONSTRAINT [PK_CustomFilters]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [PK_Events]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Landscapes'
ALTER TABLE [dbo].[Landscapes]
ADD CONSTRAINT [PK_Landscapes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [PK_Locations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [PK_Photos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [People_Id], [Photos_Id] in table 'PersonPhotoes'
ALTER TABLE [dbo].[PersonPhotoes]
ADD CONSTRAINT [PK_PersonPhotoes]
    PRIMARY KEY CLUSTERED ([People_Id], [Photos_Id] ASC);
GO

-- Creating primary key on [CustomFilters_Id], [Photos_Id] in table 'PhotoCustomFilters'
ALTER TABLE [dbo].[PhotoCustomFilters]
ADD CONSTRAINT [PK_PhotoCustomFilters]
    PRIMARY KEY CLUSTERED ([CustomFilters_Id], [Photos_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [EventId] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [FK_dbo_Photos_dbo_Events_EventId]
    FOREIGN KEY ([EventId])
    REFERENCES [dbo].[Events]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Photos_dbo_Events_EventId'
CREATE INDEX [IX_FK_dbo_Photos_dbo_Events_EventId]
ON [dbo].[Photos]
    ([EventId]);
GO

-- Creating foreign key on [LandscapeId] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [FK_dbo_Photos_dbo_Landscapes_LandscapeId]
    FOREIGN KEY ([LandscapeId])
    REFERENCES [dbo].[Landscapes]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Photos_dbo_Landscapes_LandscapeId'
CREATE INDEX [IX_FK_dbo_Photos_dbo_Landscapes_LandscapeId]
ON [dbo].[Photos]
    ([LandscapeId]);
GO

-- Creating foreign key on [LocationId] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [FK_dbo_Photos_dbo_Locations_LocationId]
    FOREIGN KEY ([LocationId])
    REFERENCES [dbo].[Locations]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Photos_dbo_Locations_LocationId'
CREATE INDEX [IX_FK_dbo_Photos_dbo_Locations_LocationId]
ON [dbo].[Photos]
    ([LocationId]);
GO

-- Creating foreign key on [People_Id] in table 'PersonPhotoes'
ALTER TABLE [dbo].[PersonPhotoes]
ADD CONSTRAINT [FK_PersonPhotoes_People]
    FOREIGN KEY ([People_Id])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Photos_Id] in table 'PersonPhotoes'
ALTER TABLE [dbo].[PersonPhotoes]
ADD CONSTRAINT [FK_PersonPhotoes_Photos]
    FOREIGN KEY ([Photos_Id])
    REFERENCES [dbo].[Photos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonPhotoes_Photos'
CREATE INDEX [IX_FK_PersonPhotoes_Photos]
ON [dbo].[PersonPhotoes]
    ([Photos_Id]);
GO

-- Creating foreign key on [CustomFilters_Id] in table 'PhotoCustomFilters'
ALTER TABLE [dbo].[PhotoCustomFilters]
ADD CONSTRAINT [FK_PhotoCustomFilters_CustomFilters]
    FOREIGN KEY ([CustomFilters_Id])
    REFERENCES [dbo].[CustomFilters]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Photos_Id] in table 'PhotoCustomFilters'
ALTER TABLE [dbo].[PhotoCustomFilters]
ADD CONSTRAINT [FK_PhotoCustomFilters_Photos]
    FOREIGN KEY ([Photos_Id])
    REFERENCES [dbo].[Photos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotoCustomFilters_Photos'
CREATE INDEX [IX_FK_PhotoCustomFilters_Photos]
ON [dbo].[PhotoCustomFilters]
    ([Photos_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
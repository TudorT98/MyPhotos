
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/30/2020 20:26:50
-- Generated from EDMX file: C:\Users\Tudor\Documents\FACULTATE\Anul 3\Semestrul2\TSP.NET\MyPhotos\MyPhotosV2\Photo.edmx
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PhotoSet'
CREATE TABLE [dbo].[PhotoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EventId1] int  ,
    [PersonId] int  ,
    [LocationId] int  ,
    [LandScapeId] int  ,
    [FullPath] nvarchar(max)  NOT NULL,
    [isMovie] nvarchar(max)  NOT NULL,
    [isRemoved] nvarchar(max)  NOT NULL,

);
GO

-- Creating table 'LandScapeSet'
CREATE TABLE [dbo].[LandScapeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LandScapeName] nvarchar(max)  NOT NULL,
    [LandScapeDescription] nvarchar(max)  NOT NULL,
	UNIQUE ([LandScapeName])
);
GO

-- Creating table 'LocationSet'
CREATE TABLE [dbo].[LocationSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LocationName] nvarchar(max)  NOT NULL,
    [LocationDescription] nvarchar(max)  NOT NULL,
    [LocationType] nvarchar(max)  NOT NULL,
	UNIQUE ([LocationName])
);
GO

-- Creating table 'EventSet'
CREATE TABLE [dbo].[EventSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EventName] nvarchar(max)  NOT NULL,
    [EventDescription] nvarchar(max)  NOT NULL,
	UNIQUE ([EventName])
);
GO

-- Creating table 'PersonSet'
CREATE TABLE [dbo].[PersonSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EventId] int  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Age] nvarchar(max)  NOT NULL,
	UNIQUE ([FirstName],[LastName])
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'PhotoSet'
ALTER TABLE [dbo].[PhotoSet]
ADD CONSTRAINT [PK_PhotoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LandScapeSet'
ALTER TABLE [dbo].[LandScapeSet]
ADD CONSTRAINT [PK_LandScapeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LocationSet'
ALTER TABLE [dbo].[LocationSet]
ADD CONSTRAINT [PK_LocationSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EventSet'
ALTER TABLE [dbo].[EventSet]
ADD CONSTRAINT [PK_EventSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PersonSet'
ALTER TABLE [dbo].[PersonSet]
ADD CONSTRAINT [PK_PersonSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PersonId] in table 'PhotoSet'
ALTER TABLE [dbo].[PhotoSet]
ADD CONSTRAINT [FK_PersonPhoto]
    FOREIGN KEY ([PersonId])
    REFERENCES [dbo].[PersonSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonPhoto'
CREATE INDEX [IX_FK_PersonPhoto]
ON [dbo].[PhotoSet]
    ([PersonId]);
GO

-- Creating foreign key on [LocationId] in table 'PhotoSet'
ALTER TABLE [dbo].[PhotoSet]
ADD CONSTRAINT [FK_LocationPhoto]
    FOREIGN KEY ([LocationId])
    REFERENCES [dbo].[LocationSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LocationPhoto'
CREATE INDEX [IX_FK_LocationPhoto]
ON [dbo].[PhotoSet]
    ([LocationId]);
GO

-- Creating foreign key on [LandScapeId] in table 'PhotoSet'
ALTER TABLE [dbo].[PhotoSet]
ADD CONSTRAINT [FK_LandScapePhoto]
    FOREIGN KEY ([LandScapeId])
    REFERENCES [dbo].[LandScapeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LandScapePhoto'
CREATE INDEX [IX_FK_LandScapePhoto]
ON [dbo].[PhotoSet]
    ([LandScapeId]);
GO

-- Creating foreign key on [EventId1] in table 'PhotoSet'
ALTER TABLE [dbo].[PhotoSet]
ADD CONSTRAINT [FK_EventPhoto]
    FOREIGN KEY ([EventId1])
    REFERENCES [dbo].[EventSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventPhoto'
CREATE INDEX [IX_FK_EventPhoto]
ON [dbo].[PhotoSet]
    ([EventId1]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------

-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 06/16/2012 12:07:00
-- Generated from EDMX file: C:\Users\fintan\Dropbox\Work\College Projects - Current\ent_frame\EF-Group-Project\EF-Group-Project\teamcanada\teamcanada\toronto.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [toronto_elections];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_WardCandidate_Ward]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WardCandidate] DROP CONSTRAINT [FK_WardCandidate_Ward];
GO
IF OBJECT_ID(N'[dbo].[FK_WardCandidate_Candidate]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WardCandidate] DROP CONSTRAINT [FK_WardCandidate_Candidate];
GO
IF OBJECT_ID(N'[dbo].[FK_CandidateContribution]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contributions] DROP CONSTRAINT [FK_CandidateContribution];
GO
IF OBJECT_ID(N'[dbo].[FK_ContributorContribution]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contributions] DROP CONSTRAINT [FK_ContributorContribution];
GO
IF OBJECT_ID(N'[dbo].[FK_CandidateElection_Candidate]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CandidateElection] DROP CONSTRAINT [FK_CandidateElection_Candidate];
GO
IF OBJECT_ID(N'[dbo].[FK_CandidateElection_Election]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CandidateElection] DROP CONSTRAINT [FK_CandidateElection_Election];
GO
IF OBJECT_ID(N'[dbo].[FK_ElectionContributor_Election]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ElectionContributor] DROP CONSTRAINT [FK_ElectionContributor_Election];
GO
IF OBJECT_ID(N'[dbo].[FK_ElectionContributor_Contributor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ElectionContributor] DROP CONSTRAINT [FK_ElectionContributor_Contributor];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Wards]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Wards];
GO
IF OBJECT_ID(N'[dbo].[Candidates]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Candidates];
GO
IF OBJECT_ID(N'[dbo].[Contributions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contributions];
GO
IF OBJECT_ID(N'[dbo].[Elections]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Elections];
GO
IF OBJECT_ID(N'[dbo].[Contributors]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contributors];
GO
IF OBJECT_ID(N'[dbo].[WardCandidate]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WardCandidate];
GO
IF OBJECT_ID(N'[dbo].[CandidateElection]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CandidateElection];
GO
IF OBJECT_ID(N'[dbo].[ElectionContributor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ElectionContributor];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Wards'
CREATE TABLE [dbo].[Wards] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [wardNum] int  NOT NULL,
    [numCandidates] int  NOT NULL,
    [wardName] nvarchar(max)  NOT NULL,
    [numWardVotes] int  NOT NULL,
    [totalWardContributions] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'Candidates'
CREATE TABLE [dbo].[Candidates] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [firstName] nvarchar(max)  NOT NULL,
    [lastName] nvarchar(max)  NOT NULL,
    [numVotes] int  NOT NULL,
    [totalContributions] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'Contributions'
CREATE TABLE [dbo].[Contributions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [amount] decimal(18,0)  NOT NULL,
    [contributionType] nvarchar(max)  NOT NULL,
    [contributorType] nvarchar(max)  NOT NULL,
    [CandidateId] int  NOT NULL,
    [ContributorId] int  NOT NULL
);
GO

-- Creating table 'Elections'
CREATE TABLE [dbo].[Elections] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [electionType] nvarchar(max)  NOT NULL,
    [year] datetime  NOT NULL,
    [totalNumVotes] int  NOT NULL,
    [totalNumCandidates] int  NOT NULL
);
GO

-- Creating table 'Contributors'
CREATE TABLE [dbo].[Contributors] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [firstName] nvarchar(max)  NOT NULL,
    [lastName] nvarchar(max)  NOT NULL,
    [postCode] int  NOT NULL,
    [relationship] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'WardCandidate'
CREATE TABLE [dbo].[WardCandidate] (
    [Wards_Id] int  NOT NULL,
    [Candidates_Id] int  NOT NULL
);
GO

-- Creating table 'CandidateElection'
CREATE TABLE [dbo].[CandidateElection] (
    [Candidates_Id] int  NOT NULL,
    [Elections_Id] int  NOT NULL
);
GO

-- Creating table 'ElectionContributor'
CREATE TABLE [dbo].[ElectionContributor] (
    [Elections_Id] int  NOT NULL,
    [Contributors_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Wards'
ALTER TABLE [dbo].[Wards]
ADD CONSTRAINT [PK_Wards]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Candidates'
ALTER TABLE [dbo].[Candidates]
ADD CONSTRAINT [PK_Candidates]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Contributions'
ALTER TABLE [dbo].[Contributions]
ADD CONSTRAINT [PK_Contributions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Elections'
ALTER TABLE [dbo].[Elections]
ADD CONSTRAINT [PK_Elections]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Contributors'
ALTER TABLE [dbo].[Contributors]
ADD CONSTRAINT [PK_Contributors]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Wards_Id], [Candidates_Id] in table 'WardCandidate'
ALTER TABLE [dbo].[WardCandidate]
ADD CONSTRAINT [PK_WardCandidate]
    PRIMARY KEY NONCLUSTERED ([Wards_Id], [Candidates_Id] ASC);
GO

-- Creating primary key on [Candidates_Id], [Elections_Id] in table 'CandidateElection'
ALTER TABLE [dbo].[CandidateElection]
ADD CONSTRAINT [PK_CandidateElection]
    PRIMARY KEY NONCLUSTERED ([Candidates_Id], [Elections_Id] ASC);
GO

-- Creating primary key on [Elections_Id], [Contributors_Id] in table 'ElectionContributor'
ALTER TABLE [dbo].[ElectionContributor]
ADD CONSTRAINT [PK_ElectionContributor]
    PRIMARY KEY NONCLUSTERED ([Elections_Id], [Contributors_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Wards_Id] in table 'WardCandidate'
ALTER TABLE [dbo].[WardCandidate]
ADD CONSTRAINT [FK_WardCandidate_Ward]
    FOREIGN KEY ([Wards_Id])
    REFERENCES [dbo].[Wards]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Candidates_Id] in table 'WardCandidate'
ALTER TABLE [dbo].[WardCandidate]
ADD CONSTRAINT [FK_WardCandidate_Candidate]
    FOREIGN KEY ([Candidates_Id])
    REFERENCES [dbo].[Candidates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_WardCandidate_Candidate'
CREATE INDEX [IX_FK_WardCandidate_Candidate]
ON [dbo].[WardCandidate]
    ([Candidates_Id]);
GO

-- Creating foreign key on [CandidateId] in table 'Contributions'
ALTER TABLE [dbo].[Contributions]
ADD CONSTRAINT [FK_CandidateContribution]
    FOREIGN KEY ([CandidateId])
    REFERENCES [dbo].[Candidates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CandidateContribution'
CREATE INDEX [IX_FK_CandidateContribution]
ON [dbo].[Contributions]
    ([CandidateId]);
GO

-- Creating foreign key on [ContributorId] in table 'Contributions'
ALTER TABLE [dbo].[Contributions]
ADD CONSTRAINT [FK_ContributorContribution]
    FOREIGN KEY ([ContributorId])
    REFERENCES [dbo].[Contributors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ContributorContribution'
CREATE INDEX [IX_FK_ContributorContribution]
ON [dbo].[Contributions]
    ([ContributorId]);
GO

-- Creating foreign key on [Candidates_Id] in table 'CandidateElection'
ALTER TABLE [dbo].[CandidateElection]
ADD CONSTRAINT [FK_CandidateElection_Candidate]
    FOREIGN KEY ([Candidates_Id])
    REFERENCES [dbo].[Candidates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Elections_Id] in table 'CandidateElection'
ALTER TABLE [dbo].[CandidateElection]
ADD CONSTRAINT [FK_CandidateElection_Election]
    FOREIGN KEY ([Elections_Id])
    REFERENCES [dbo].[Elections]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CandidateElection_Election'
CREATE INDEX [IX_FK_CandidateElection_Election]
ON [dbo].[CandidateElection]
    ([Elections_Id]);
GO

-- Creating foreign key on [Elections_Id] in table 'ElectionContributor'
ALTER TABLE [dbo].[ElectionContributor]
ADD CONSTRAINT [FK_ElectionContributor_Election]
    FOREIGN KEY ([Elections_Id])
    REFERENCES [dbo].[Elections]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Contributors_Id] in table 'ElectionContributor'
ALTER TABLE [dbo].[ElectionContributor]
ADD CONSTRAINT [FK_ElectionContributor_Contributor]
    FOREIGN KEY ([Contributors_Id])
    REFERENCES [dbo].[Contributors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ElectionContributor_Contributor'
CREATE INDEX [IX_FK_ElectionContributor_Contributor]
ON [dbo].[ElectionContributor]
    ([Contributors_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
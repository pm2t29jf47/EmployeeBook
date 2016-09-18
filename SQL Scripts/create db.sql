USE [Master]
GO

CREATE DATABASE [EmployeeBook]
GO

USE [EmployeeBook]
GO

CREATE TABLE [Employee](
[ID] [uniqueidentifier] CONSTRAINT [DF_Employee_ID] DEFAULT NEWSEQUENTIALID() ROWGUIDCOL NOT NULL,
[FirstName]  [nvarchar](128) NOT NULL,
[SecondName]  [nvarchar](128) NOT NULL,
[ThirdName]  [nvarchar](128) NOT NULL,
[MainPhoneNumber]  [nvarchar](32) NULL,
[Comment]  [nvarchar](4000) NULL,
CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED ([ID]))
GO


CREATE TABLE [Position](
[ID] [uniqueidentifier] CONSTRAINT [DF_Position_ID] DEFAULT NEWSEQUENTIALID() ROWGUIDCOL NOT NULL,
[Name]  [nvarchar](128) NOT NULL,
[Comment]  [nvarchar](4000) NULL,
CONSTRAINT [PK_Position] PRIMARY KEY CLUSTERED ([ID]))
GO


CREATE TABLE [Skill](
[ID] [uniqueidentifier] CONSTRAINT [DF_Skill_ID] DEFAULT NEWSEQUENTIALID() ROWGUIDCOL NOT NULL,
[Name]  [nvarchar](128) NOT NULL,
[Comment]  [nvarchar](4000) NULL,
CONSTRAINT [PK_Skill] PRIMARY KEY CLUSTERED ([ID]))
GO


CREATE TABLE [EmployeePosition](
[ID] [uniqueidentifier] CONSTRAINT [DF_EmployeePosition_ID] DEFAULT NEWSEQUENTIALID() ROWGUIDCOL NOT NULL,
[EmployeeID] [uniqueidentifier] NOT NULL,
[PositionID] [uniqueidentifier] NOT NULL,
[AssignmentDate] [datetime2] NOT NULL,
CONSTRAINT [PK_EmployeePosition] PRIMARY KEY CLUSTERED ([ID]))
GO

ALTER TABLE [dbo].[EmployeePosition]  WITH CHECK ADD CONSTRAINT [FK_EmployeePosition_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO

ALTER TABLE [dbo].[EmployeePosition]  WITH CHECK ADD CONSTRAINT [FK_EmployeePosition_Position] FOREIGN KEY([PositionID])
REFERENCES [dbo].[Position] ([ID])
GO


CREATE TABLE [PositionSkill](
[ID] [uniqueidentifier] CONSTRAINT [DF_PositionSkill_ID] DEFAULT NEWSEQUENTIALID() ROWGUIDCOL NOT NULL,
[PositionID] [uniqueidentifier] NOT NULL,
[SkillID] [uniqueidentifier] NOT NULL,
CONSTRAINT [PK_PositionSkill] PRIMARY KEY CLUSTERED ([ID]))
GO

ALTER TABLE [dbo].[PositionSkill]  WITH CHECK ADD CONSTRAINT [FK_PositionSkill_Position] FOREIGN KEY([PositionID])
REFERENCES [dbo].[Position] ([ID])
GO

ALTER TABLE [dbo].[PositionSkill]  WITH CHECK ADD CONSTRAINT [FK_PositionSkill_Skill] FOREIGN KEY([SkillID])
REFERENCES [dbo].[Skill] ([ID])
GO

CREATE TABLE [EmployeePositionSkill](
[ID] [uniqueidentifier] CONSTRAINT [DF_EmployeePositionSkill_ID] DEFAULT NEWSEQUENTIALID() ROWGUIDCOL NOT NULL,
[EmployeeID] [uniqueidentifier] NOT NULL,
[PositionSkillID] [uniqueidentifier] NOT NULL,
[AssignmentDate] [datetime2] NOT NULL,
CONSTRAINT [PK_EmployeePositionSkill] PRIMARY KEY CLUSTERED ([ID]))
GO

ALTER TABLE [dbo].[EmployeePositionSkill]  WITH CHECK ADD CONSTRAINT [FK_EmployeePositionSkill_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO

ALTER TABLE [dbo].[EmployeePositionSkill]  WITH CHECK ADD CONSTRAINT [FK_EmployeePositionSkill_PositionSkill] FOREIGN KEY([PositionSkillID])
REFERENCES [dbo].[PositionSkill] ([ID])
GO
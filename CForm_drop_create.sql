USE [Anandashram]
GO

ALTER TABLE [dbo].[CForms] DROP CONSTRAINT [FK_CForms_Devotees]
GO

/****** Object:  Table [dbo].[CForms]    Script Date: 23-06-2026 13:32:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CForms]') AND type in (N'U'))
DROP TABLE [dbo].[CForms]
GO

/****** Object:  Table [dbo].[CForms]    Script Date: 23-06-2026 13:32:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CForms](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DevoteeId] [int] NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100) NULL,
	[Sex] [int] NULL,
	[DOB] [date] NULL,
	[SpecialCategory] [int] NULL,
	[Nationality] [nvarchar](100) NULL,
	[Address] [nvarchar](500) NULL,
	[City] [nvarchar](100) NULL,
	[Country] [nvarchar](100) NULL,
	[ReferenceAddress] [nvarchar](500) NULL,
	[ReferenceState] [nvarchar](100) NULL,
	[ReferenceCity] [nvarchar](100) NULL,
	[ReferencePincode] [nvarchar](20) NULL,
	[PassportNo] [nvarchar](50) NULL,
	[PassportIssueCity] [nvarchar](100) NULL,
	[PassportIssueCountry] [nvarchar](100) NULL,
	[PassportDateOfIssue] [date] NULL,
	[PassportDateOfExpiry] [date] NULL,
	[VisaNumber] [nvarchar](50) NULL,
	[VisaCity] [nvarchar](100) NULL,
	[VisaCountry] [nvarchar](100) NULL,
	[VisaDateOfIssue] [date] NULL,
	[VisaDateOfExpiry] [date] NULL,
	[VisaType] [nvarchar](100) NULL,
	[VisaSubType] [nvarchar](100) NULL,
	[ArrivedFromCountry] [nvarchar](100) NULL,
	[ArrivedFromCity] [nvarchar](100) NULL,
	[DateOfArrivalInIndia] [date] NULL,
	[ArrivedFromPlaceInIndia] [nvarchar](100) NULL,
	[DateOfArrivalInAnandAshram] [date] NULL,
	[TimeOfArrivalInAnandAshram] [time](7) NULL,
	[DurationOfStay] [int] NULL,
	[IsEmployedInIndia] [bit] NULL,
	[PurposeOfVisit] [nvarchar](500) NULL,
	[NextDestination] [int] NULL,
	[DestinationCountry] [nvarchar](100) NULL,
	[DestinationState] [nvarchar](100) NULL,
	[DestinationCity] [nvarchar](100) NULL,
	[Place] [nvarchar](200) NULL,
	[ContactPhoneNumber] [nvarchar](50) NULL,
	[MobileNumber] [nvarchar](50) NULL,
	[PermanentCountryPhone] [nvarchar](50) NULL,
	[PermanentCountryMobile] [nvarchar](50) NULL,
	[Remarks] [nvarchar](1000) NULL,
 CONSTRAINT [PK_CForms] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__CForms__985AC774F191604F] UNIQUE NONCLUSTERED 
(
	[DevoteeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CForms]  WITH CHECK ADD  CONSTRAINT [FK_CForms_Devotees] FOREIGN KEY([DevoteeId])
REFERENCES [dbo].[Devotees] ([Id])
GO

ALTER TABLE [dbo].[CForms] CHECK CONSTRAINT [FK_CForms_Devotees]
GO



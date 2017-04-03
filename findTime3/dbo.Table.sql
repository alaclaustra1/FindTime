CREATE TABLE [dbo].[NewTask]
(
	[NewTask] VARCHAR(MAX) NOT NULL PRIMARY KEY, 
    [StartTime] TIME NOT NULL, 
    [EndTime] TIME NOT NULL, 
    [Description] VARCHAR(MAX) NULL
)

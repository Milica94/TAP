USE [TAP]
GO
/****** Object:  Table [dbo].[client]    Script Date: 10/30/2020 4:57:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[client](
	[id] [int] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[created_at] [datetime] NOT NULL,
 CONSTRAINT [client_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[project]    Script Date: 10/30/2020 4:57:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[project](
	[id] [int] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[created_at] [datetime] NOT NULL,
	[status] [varchar](11) NOT NULL,
	[client_id] [int] NOT NULL,
 CONSTRAINT [project_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[project]  WITH CHECK ADD  CONSTRAINT [project_client_fk] FOREIGN KEY([client_id])
REFERENCES [dbo].[client] ([id])
GO
ALTER TABLE [dbo].[project] CHECK CONSTRAINT [project_client_fk]
GO
ALTER TABLE [dbo].[project]  WITH CHECK ADD CHECK  (([status]='closed' OR [status]='opened' OR [status]='in_progress'))
GO

USE [QLNV]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 5/17/2021 10:28:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [int] IDENTITY(1,1) NOT NULL,
	[HO] [nvarchar](50) NULL,
	[TEN] [nvarchar](50) NULL,
	[PHAI] [nvarchar](50) NULL,
	[DIACHI] [nvarchar](50) NULL,
	[NGAYSINH] [date] NULL,
	[LUONG] [int] NULL,
	[MACN] [nchar](20) NULL,
	[TRANGTHAI] [bit] NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON 

INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [TRANGTHAI]) VALUES (1, N'Nguyễn', N'Hiếu', N'Nữ', N'TP HCM', CAST(N'1999-09-25' AS Date), 10000000, N'TPHCM               ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [TRANGTHAI]) VALUES (2, N'Nguyễn ', N'Hương', N'Nữ', N'Quảng Bình', CAST(N'1999-04-30' AS Date), 20000000, N'TPHCM               ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [TRANGTHAI]) VALUES (3, N'Hà1', N'Mai', N'Nữ', N'Thanh Hóa', CAST(N'2000-01-01' AS Date), 10000000, N'TPHCM               ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [TRANGTHAI]) VALUES (4, N'Quách', N'Hồng Thư', N'Nam', N'Bạc Liêu', CAST(N'1999-07-07' AS Date), 15000000, N'TPHCM               ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [TRANGTHAI]) VALUES (5, N'Nguyễn ', N'Nam', N'Nữ', N'TP Hà Nội', CAST(N'1998-01-05' AS Date), 15000000, N'TPHCM               ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [TRANGTHAI]) VALUES (6, N'Hà', N'Nam Thư', N'Nữ', N'Bình Thuận', CAST(N'2021-04-14' AS Date), 1000000000, N'TPHCM               ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [TRANGTHAI]) VALUES (7, N'Nguyễn', N'Hi', N'Nam', N'Cà Mau', CAST(N'1994-12-14' AS Date), 100020000, N'TPHCM               ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [TRANGTHAI]) VALUES (8, N'Hà', N'Anh Tuấn', N'Nam', N'Bình Định', CAST(N'2021-05-14' AS Date), 120000000, N'TPHCM               ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [TRANGTHAI]) VALUES (9, N'CC', N'a', N'Nữ', N'a', CAST(N'2021-05-14' AS Date), 12, N'TPHCM               ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [TRANGTHAI]) VALUES (10, N'a', N'aa', N'Nữ', N'a', CAST(N'2021-05-14' AS Date), 12, N'TPHCM               ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [TRANGTHAI]) VALUES (11, N'f', N'd', N'Nữ', N'd', CAST(N'2021-05-14' AS Date), 12, N'TPHCM               ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [TRANGTHAI]) VALUES (12, N'et', N'gdfx', N'Nữ', N'dg', CAST(N'2021-05-17' AS Date), 12, N'TPHCM               ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [TRANGTHAI]) VALUES (13, N'AbcD', N'A', N'Nữ', N'A', CAST(N'2021-05-17' AS Date), 12, N'TPHCM               ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [TRANGTHAI]) VALUES (14, N'sf', N'f', N'Nữ', N'f', CAST(N'2021-05-17' AS Date), 12, N'TPHCM               ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [TRANGTHAI]) VALUES (15, N'a', N'a', N'Nam', N'a', CAST(N'2021-05-17' AS Date), 12, N'TPHCM               ', 1)
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
/****** Object:  StoredProcedure [dbo].[Sp_DeleteNV]    Script Date: 5/17/2021 10:28:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Sp_DeleteNV](@MANV int)
AS
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM NHANVIEN WHERE MANV = @MANV AND TRANGTHAI = 'False') RAISERROR ('MANV not exist or deleted before!', 16, 1);
		UPDATE NHANVIEN 
		SET	TRANGTHAI = '1'
		WHERE MANV = @MANV;
		COMMIT
	END TRY
	BEGIN CATCH
		
		ROLLBACK;

	DECLARE @Message varchar(MAX) = ERROR_MESSAGE(),
        @Severity int = ERROR_SEVERITY(),
        @State smallint = ERROR_STATE()
 
	RAISERROR (@Message, @Severity, @State)
	END CATCH


GO
/****** Object:  StoredProcedure [dbo].[Sp_ThemNV]    Script Date: 5/17/2021 10:28:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Sp_ThemNV](@HO nvarchar(50), @TEN nvarchar(50), @PHAI nvarchar(50), @DIACHI nvarchar(50),
				@NGAYSINH date, @LUONG int, @MACN nchar(20))
AS
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
BEGIN TRAN
BEGIN TRY
		INSERT INTO NHANVIEN VALUES( @HO, @TEN, @PHAI, @DIACHI, @NGAYSINH, @LUONG, 'TPHCM', 0); 
	COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
END CATCH



GO
/****** Object:  StoredProcedure [dbo].[Sp_UpdateNV]    Script Date: 5/17/2021 10:28:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Sp_UpdateNV](@MANV int,@HO nvarchar(50), @TEN nvarchar(50), @PHAI nvarchar(50), @DIACHI nvarchar(50),
				@NGAYSINH date, @LUONG int, @MACN nchar(20))
AS
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM NHANVIEN WHERE MANV = @MANV AND TRANGTHAI = 'False') RAISERROR ('MANV not exist or deleted before!', 16, 1);
		UPDATE NHANVIEN 
		SET	HO = @HO, TEN = @TEN, PHAI = @PHAI, DIACHI = @DIACHI, NGAYSINH = @NGAYSINH, LUONG = @LUONG
		WHERE MANV = @MANV;
		COMMIT
	END TRY
	BEGIN CATCH
			ROLLBACK;

			DECLARE @Message varchar(MAX) = ERROR_MESSAGE(),
				@Severity int = ERROR_SEVERITY(),
				@State smallint = ERROR_STATE()
 
			RAISERROR (@Message, @Severity, @State)
	END CATCH

GO

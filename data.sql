USE [QLNV]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 4/25/2021 7:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [nchar](20) NOT NULL,
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
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [TRANGTHAI]) VALUES (N'NV1                 ', N'Nguyễn', N'Hiếu', N'Nam', N'TP HCM', CAST(N'1999-09-25' AS Date), 10000000, N'TPHCM               ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [TRANGTHAI]) VALUES (N'NV2                 ', N'Nguyễn', N'Hương', N'Nữ', N'Quảng Bình', CAST(N'1999-04-30' AS Date), 20000000, N'TPHCM               ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [TRANGTHAI]) VALUES (N'NV3                 ', N'Hà', N'Mai', N'Nữ', N'Thanh Hóa', CAST(N'2000-01-01' AS Date), 10000000, N'TPHCM               ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [TRANGTHAI]) VALUES (N'NV4                 ', N'Quách', N'Hồng Thư', N'Nam', N'Bạc Liêu', CAST(N'1999-07-07' AS Date), 15000000, N'TPHCM               ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [TRANGTHAI]) VALUES (N'NV5                 ', N'Nguyễn ', N'Nam', N'Nam', N'TP Hà Nội', CAST(N'1998-01-05' AS Date), 15000000, N'TPHCM               ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [TRANGTHAI]) VALUES (N'NV6                 ', N'Hà', N'Nam Thư', N'Nữ', N'Bình Thuận', CAST(N'2021-04-14' AS Date), 1000000000, N'TPHCM               ', 0)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [TRANGTHAI]) VALUES (N'NV7                 ', N'Nguyễn', N'Hi', N'Nam', N'Cà Mau', CAST(N'1994-12-14' AS Date), 100020000, N'TPHCM               ', 0)
/****** Object:  StoredProcedure [dbo].[Sp_DeleteNV]    Script Date: 4/25/2021 7:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Sp_DeleteNV](@MANV nchar(50))
AS
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
BEGIN TRAN
UPDATE NHANVIEN 
SET	TRANGTHAI = '1'
WHERE MANV = @MANV;
COMMIT

GO
/****** Object:  StoredProcedure [dbo].[Sp_ThemNV]    Script Date: 4/25/2021 7:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Sp_ThemNV](@MANV nchar(20), @HO nvarchar(50), @TEN nvarchar(50), @PHAI nvarchar(50), @DIACHI nvarchar(50),
				@NGAYSINH date, @LUONG int, @MACN nchar(20))
AS
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
BEGIN TRAN
BEGIN TRY
	IF(@MANV = ' ') RAISERROR ('MANV trống', 16, 1);
	INSERT INTO NHANVIEN VALUES(@MANV, @HO, @TEN, @PHAI, @DIACHI, @NGAYSINH, @LUONG, 'TPHCM', 0); 
	COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
END CATCH


GO
/****** Object:  StoredProcedure [dbo].[Sp_UpdateNV]    Script Date: 4/25/2021 7:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Sp_UpdateNV](@MANV nvarchar(50),@HO nvarchar(50), @TEN nvarchar(50), @PHAI nvarchar(50), @DIACHI nvarchar(50),
				@NGAYSINH date, @LUONG int, @MACN nchar(20))
AS
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
BEGIN TRAN
UPDATE NHANVIEN 
SET	HO = @HO, TEN = @TEN, PHAI = @PHAI, DIACHI = @DIACHI, NGAYSINH = @NGAYSINH, LUONG = @LUONG
WHERE MANV = @MANV;
COMMIT

GO

﻿CREATE TABLE [dbo].[Pages] (
    [PageId] [int] NOT NULL IDENTITY,
    [Name] [nvarchar](max),
    [Description] [nvarchar](max),
    CONSTRAINT [PK_dbo.Pages] PRIMARY KEY ([PageId])
)
CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId] [nvarchar](150) NOT NULL,
    [ContextKey] [nvarchar](300) NOT NULL,
    [Model] [varbinary](max) NOT NULL,
    [ProductVersion] [nvarchar](32) NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
)
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201705180855048_Initial', N'NetCourse.Migrations.Configuration',  0x1F8B0800000000000400CD57CD6EE33610BE17E83B083CB540D68C934B1B48BBC8DA716174ED18ABECDE6969EC10A54895A452FBD97AE823F5153A14F56729769C60812E02043639F3CDCC377FF4BF7FFF137ED8652278026DB89211198F2E490032512997DB881476F3EE17F2E1FD8F3F847769B60BBED672D74E0E35A589C8A3B5F90DA52679848C9951C613AD8CDAD851A232CA5245AF2E2F7FA5E331058420881504E1E7425A9E41F905BF4E944C20B705130B958230D539DEC4256AB06419989C25109125D8892AB481D112FE9A2991821E93E0567086BEC420362460522ACB2C7A7AF3C5406CB592DB38C703261EF639A0DC860903550437ADF8B9C15C5EB96068AB58432585B12A7B25E0F8BA6287F6D5DFC43169D843FEEE9067BB7751971C4664C5B61878DFD0CD446827D4A5D7A762E4142E82E6F8A22902AC15F777114C0A610B0D9184C26A262E8255B1163CF91DF60FEA0F90912C84E83A856EE1DDC1011EADB4CA41DBFD67D8745C9DA724A087BAB4AFDCA8F6F47C407369AFAF48B04427D85A4093FB4EF0B1551A7E03099A594857CC5AD098BA790A257B030F7AF6DCFFDA1A161B760E09166CF709E4D63E46043F9260C67790D62795075F24C7464325AB0B78C9C8144CA279EEABE29BDA0A695B24C3D2C1D6B48C233575B075214CD7EE0A76F6996AC2AEAB0ACA54160F63F3D031D80A34C78C1912B47EF84E1EF9627DCED9C6AD7654503F2BEA99428F0C9570C1F21C79EB0C99EA2488FD8499BC8B5FDF7899C7A08979A6FF1A6F1B4B5871185BEF164DA3A733AE8D9D32CBD6CC656E926603B167927084E0DA6097E77EE7B5B4D7D2EE732FDD9D69EBD3D24369699C616419764E1924349E54A367A0560E7926983ED2C513258A4C9E9A08A7507C6F7631FCC9F908078DD7053AB818E285B4C7479F763AE0BD37E7FA493CD5067D91C67AD30EBDB20FAB127C79E10E6AD28B9000897AE2A9ABC7786F2C642327308AFF1413C131DE5660C124DF80B17E1D10DC7857BD8DFDFD6C4F6A4C2ACE58A1FFDB3EE38ED91737D660DD9DBFC2E413D3C923D33F656CF77317E98D6BEA1578AF5B45C361797ACBF86D7264C9F8A28E48BA56E8B87770E5D7D21BF7CFB0C142DA7DF786C815DFB610EE152C2171D4B5A0B5CC5C6E544D3546D4F5A816E965620196A548CCADB67CC3128BD7091853BE18BE3251A0C85DB686742EEF0B9B17F6D618C8D6E2E0B513D2D3F6CB257BE873785F26DF7C8B10D04D8E21C0BDFC587091367ECF86257D0CC2D548D527E815BE98106EBB6F90964A9E0954D137851CA4EBB207C8728160E65EC6EC09DEE21BBE923EC19625FB7A4E1E0779391187B48753CEB69A65A6C268F5DD6F39EA7ECCBDFF0FA6C0C258FE0D0000 , N'6.1.3-40302')


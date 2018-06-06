CREATE TABLE [dbo].[input_barang] (
    [id_barang]    VARCHAR(20)          NOT NULL,
    [nama_brg]  VARCHAR (20) NULL,
    [jenis_brg] VARCHAR (20) NULL,
    [harga_brg]        INT          NULL,
    [jum_msk] INT          NULL,
    PRIMARY KEY CLUSTERED ([id_barang] ASC)
);


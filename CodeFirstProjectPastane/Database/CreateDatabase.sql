IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Departmans] (
    [DepartmanId] int NOT NULL IDENTITY,
    [DepartmanAdi] nvarchar(max) NULL,
    [PersonelSayisi] int NOT NULL,
    CONSTRAINT [PK_Departmans] PRIMARY KEY ([DepartmanId])
);
GO

CREATE TABLE [Musteris] (
    [MusteriId] int NOT NULL IDENTITY,
    [AdSoyad] nvarchar(max) NULL,
    [Adres] nvarchar(max) NULL,
    [Telefon] nvarchar(max) NULL,
    [Eposta] nvarchar(max) NULL,
    CONSTRAINT [PK_Musteris] PRIMARY KEY ([MusteriId])
);
GO

CREATE TABLE [Tedarikcis] (
    [TedarikciId] int NOT NULL IDENTITY,
    [TedarikciFirma] nvarchar(max) NULL,
    [Adres] nvarchar(max) NULL,
    [Telefon] nvarchar(max) NULL,
    [Eposta] nvarchar(max) NULL,
    [Malzeme] nvarchar(max) NULL,
    CONSTRAINT [PK_Tedarikcis] PRIMARY KEY ([TedarikciId])
);
GO

CREATE TABLE [Uruns] (
    [UrunId] int NOT NULL IDENTITY,
    [UrunAd] nvarchar(max) NOT NULL,
    [Fiyat] decimal(18,2) NOT NULL,
    [Adet] int NOT NULL,
    [Kategori] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Uruns] PRIMARY KEY ([UrunId])
);
GO

CREATE TABLE [Personels] (
    [PersonelId] int NOT NULL IDENTITY,
    [AdSoyad] nvarchar(max) NULL,
    [Yas] int NOT NULL,
    [Deneyim] int NOT NULL,
    [Adres] nvarchar(max) NULL,
    [Eposta] nvarchar(max) NULL,
    [Telefon] nvarchar(max) NULL,
    [Cinsiyet] nvarchar(max) NOT NULL,
    [DepartmanId] int NOT NULL,
    CONSTRAINT [PK_Personels] PRIMARY KEY ([PersonelId]),
    CONSTRAINT [FK_Personels_Departmans_DepartmanId] FOREIGN KEY ([DepartmanId]) REFERENCES [Departmans] ([DepartmanId]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Personels_DepartmanId] ON [Personels] ([DepartmanId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250629174521_InitialCreate', N'7.0.16');
GO

COMMIT;
GO


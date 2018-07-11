CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);

CREATE TABLE "Movie" (
    "ID" INTEGER NOT NULL CONSTRAINT "PK_Movie" PRIMARY KEY AUTOINCREMENT,
    "Genre" TEXT NULL,
    "Price" TEXT NOT NULL,
    "ReleaseDate" TEXT NOT NULL,
    "Title" TEXT NULL
);

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20180110090110_InitialCreate', '2.0.1-rtm-125');

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20180305155735_script', '2.0.1-rtm-125');

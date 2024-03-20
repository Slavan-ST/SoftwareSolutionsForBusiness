SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------------------------------------------------------
-- Table dbo.Country
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `Country` (
  `Code` CHAR(2) CHARACTER SET 'utf8mb4' NOT NULL,
  `Name` VARCHAR(100) CHARACTER SET 'utf8mb4' NOT NULL,
  PRIMARY KEY (`Code`));

-- ----------------------------------------------------------------------------
-- Table dbo.Hotel
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `Hotel` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(100) CHARACTER SET 'utf8mb4' NOT NULL,
  `CountOfStars` INT NOT NULL,
  `CountryCode` CHAR(2) CHARACTER SET 'utf8mb4' NOT NULL,
  `Description` LONGTEXT CHARACTER SET 'utf8mb4' NULL,
  PRIMARY KEY (`Id`),
  CONSTRAINT `FK_Hotel_Country`
    FOREIGN KEY (`CountryCode`)
    REFERENCES `Country` (`Code`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table dbo.HotelComment
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `HotelComment` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `HotelId` INT NOT NULL,
  `Text` LONGTEXT CHARACTER SET 'utf8mb4' NOT NULL,
  `Author` VARCHAR(100) CHARACTER SET 'utf8mb4' NOT NULL,
  `CreationDate` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  CONSTRAINT `FK_HotelComment_Hotel`
    FOREIGN KEY (`HotelId`)
    REFERENCES `Hotel` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table dbo.HotelImage
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `HotelImage` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `HotelId` INT NOT NULL,
  `ImageSource` LONGBLOB NOT NULL,
  PRIMARY KEY (`Id`),
  CONSTRAINT `FK_HotelImage_Hotel`
    FOREIGN KEY (`HotelId`)
    REFERENCES `Hotel` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table dbo.HotelOfTour
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `HotelOfTour` (
  `HotelId` INT NOT NULL,
  `TourId` INT NOT NULL,
  PRIMARY KEY (`HotelId`, `TourId`),
  CONSTRAINT `FK_HotelOfTour_Hotel`
    FOREIGN KEY (`HotelId`)
    REFERENCES `Hotel` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_HotelOfTour_Tour`
    FOREIGN KEY (`TourId`)
    REFERENCES `Tour` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table dbo.Tour
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `Tour` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `TicketCount` INT NOT NULL,
  `Name` VARCHAR(100) CHARACTER SET 'utf8mb4' NOT NULL,
  `Description` LONGTEXT CHARACTER SET 'utf8mb4' NULL,
  `ImagePreview` LONGBLOB NULL,
  `Price` DECIMAL(19,4) NOT NULL,
  `IsActual` TINYINT(1) NOT NULL,
  PRIMARY KEY (`Id`));

-- ----------------------------------------------------------------------------
-- Table dbo.Type
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `Type` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(100) CHARACTER SET 'utf8mb4' NOT NULL,
  `Description` LONGTEXT CHARACTER SET 'utf8mb4' NULL,
  PRIMARY KEY (`Id`));

-- ----------------------------------------------------------------------------
-- Table dbo.TypeOfTour
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `TypeOfTour` (
  `TourId` INT NOT NULL,
  `TypeId` INT NOT NULL,
  PRIMARY KEY (`TourId`, `TypeId`),
  CONSTRAINT `FK_TypeOfTour_Tour`
    FOREIGN KEY (`TourId`)
    REFERENCES `Tour` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_TypeOfTour_Type`
    FOREIGN KEY (`TypeId`)
    REFERENCES `Type` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

SET FOREIGN_KEY_CHECKS = 1;

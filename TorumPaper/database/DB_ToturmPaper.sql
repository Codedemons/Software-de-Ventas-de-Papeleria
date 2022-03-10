-- MySQL Script generated by MySQL Workbench
-- Tue Mar  8 20:53:58 2022
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema TorumPaper
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema TorumPaper
-- -----------------------------------------------------
CREATE DATABASE IF NOT EXISTS `TorumPaper` DEFAULT CHARACTER SET utf8 ;
USE `TorumPaper` ;

-- -----------------------------------------------------
-- Table `TorumPaper`.`PROVEEDOR`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TorumPaper`.`PROVEEDOR` (
  `rfcProveedor` CHAR(6) NOT NULL,
  `nombreProveedor` VARCHAR(45) NULL,
  `correoProveedor` VARCHAR(45) NULL,
  `telefonoProveedor` CHAR(10) NULL,
  `calificacionProveedor` INT NULL,
  PRIMARY KEY (`rfcProveedor`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TorumPaper`.`TIPOPRODUCTO`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TorumPaper`.`TIPOPRODUCTO` (
  `claveTipoProducto` CHAR(6) NOT NULL,
  `descripcionTipoProducto` VARCHAR(45) NULL,
  PRIMARY KEY (`claveTipoProducto`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TorumPaper`.`PRODUCTO`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TorumPaper`.`PRODUCTO` (
  `claveProducto` CHAR(6) NOT NULL,
  `claveTipoProducto` CHAR(6) NOT NULL,
  `descripcionProducto` VARCHAR(45) NULL,
  `marcaProducto` VARCHAR(45) NULL,
  `precioProducto` DECIMAL(6,2) NULL,
  `stockMinimo` INT NULL,
  `stockMaximo` INT NULL,
  `stockDisponible` INT NULL,
  PRIMARY KEY (`claveProducto`),
    INDEX `fk_PRODUCTO_TIPOPRODUCTO1_idx` (`claveTipoProducto` ASC) ,
CONSTRAINT `fk_PRODUCTO_TIPOPRODUCTO1`
    FOREIGN KEY (`claveTipoProducto`)
    REFERENCES `TorumPaper`.`TIPOPRODUCTO` (`claveTipoProducto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TorumPaper`.`VENTA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TorumPaper`.`VENTA` (
  `claveVenta` CHAR(6) NOT NULL,
  `claveProducto` CHAR(6) NOT NULL,
  `unidadesVenta` INT NULL,
  `montoVenta` DECIMAL(6,2) NULL,
  `fechaVenta` DATE NULL,
  `horaVenta` TIME NULL,
  PRIMARY KEY (`claveVenta`, `claveProducto`),
  INDEX `fk_VENTA_PRODUCTO1_idx` (`claveProducto` ASC),
  CONSTRAINT `fk_VENTA_PRODUCTO1`
    FOREIGN KEY (`claveProducto`)
    REFERENCES `TorumPaper`.`PRODUCTO` (`claveProducto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TorumPaper`.`PEDIDO`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TorumPaper`.`PEDIDO` (
  `clavePedido` CHAR(6) NOT NULL,
  `claveProducto` CHAR(6) NOT NULL,
  `rfcProveedor` CHAR(6) NOT NULL,
  `cantidadPedido` INT NULL,
  `precioPedido` DECIMAL(6,2) NULL,
  `fechaPedido` DATE NULL,
  `horaPedido` TIME NULL,
  PRIMARY KEY (`clavePedido`, `claveProducto`, `rfcProveedor`),
  INDEX `fk_PEDIDO_PRODUCTO1_idx` (`claveProducto` ASC) ,
  INDEX `fk_PEDIDO_PROVEEDOR1_idx` (`rfcProveedor` ASC) ,
  CONSTRAINT `fk_PEDIDO_PRODUCTO1`
    FOREIGN KEY (`claveProducto`)
    REFERENCES `TorumPaper`.`PRODUCTO` (`claveProducto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_PEDIDO_PROVEEDOR1`
    FOREIGN KEY (`rfcProveedor`)
    REFERENCES `TorumPaper`.`PROVEEDOR` (`rfcProveedor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

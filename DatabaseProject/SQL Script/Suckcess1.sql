-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema trainproject
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema trainproject
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `trainproject` DEFAULT CHARACTER SET utf8mb4 ;
USE `trainproject` ;

-- -----------------------------------------------------
-- Table `trainproject`.`payment`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trainproject`.`payment` (
  `payment_id` INT(11) NOT NULL,
  `payment_date` VARCHAR(45) NULL DEFAULT NULL,
  `payment_amount` VARCHAR(45) NULL DEFAULT NULL,
  `payment_status` VARCHAR(2) NOT NULL,
  `payment_method` VARCHAR(45) NOT NULL,
  `payment_num` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`payment_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `trainproject`.`route`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trainproject`.`route` (
  `route_id` INT(11) NOT NULL,
  `arrival_time` VARCHAR(45) NULL DEFAULT NULL,
  `depart_time` VARCHAR(45) NULL DEFAULT NULL,
  `route_name` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`route_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `trainproject`.`station`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trainproject`.`station` (
  `station_id` INT(11) NOT NULL AUTO_INCREMENT,
  `station_name` VARCHAR(45) NOT NULL,
  `station_distance` FLOAT NOT NULL,
  PRIMARY KEY (`station_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `trainproject`.`train`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trainproject`.`train` (
  `train_id` INT(11) NOT NULL,
  `train_type` VARCHAR(45) NOT NULL,
  `route_route_id` INT(11) NOT NULL,
  `station_station_id` INT(11) NOT NULL,
  PRIMARY KEY (`train_id`),
  INDEX `fk_train_route1_idx` (`route_route_id` ASC) ,
  INDEX `fk_train_station1_idx` (`station_station_id` ASC) ,
  CONSTRAINT `fk_train_route1`
    FOREIGN KEY (`route_route_id`)
    REFERENCES `trainproject`.`route` (`route_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_train_station1`
    FOREIGN KEY (`station_station_id`)
    REFERENCES `trainproject`.`station` (`station_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `trainproject`.`station_has_route`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trainproject`.`station_has_route` (
  `station_station_id` INT(11) NOT NULL,
  `route_route_id` INT(11) NOT NULL,
  `train_train_id` INT(11) NOT NULL,
  PRIMARY KEY (`station_station_id`, `route_route_id`, `train_train_id`),
  INDEX `fk_station_has_route_route1_idx` (`route_route_id` ASC) ,
  INDEX `fk_station_has_route_station1_idx` (`station_station_id` ASC) ,
  INDEX `fk_station_has_route_train1_idx` (`train_train_id` ASC) ,
  CONSTRAINT `fk_station_has_route_route1`
    FOREIGN KEY (`route_route_id`)
    REFERENCES `trainproject`.`route` (`route_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_station_has_route_station1`
    FOREIGN KEY (`station_station_id`)
    REFERENCES `trainproject`.`station` (`station_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_station_has_route_train1`
    FOREIGN KEY (`train_train_id`)
    REFERENCES `trainproject`.`train` (`train_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `trainproject`.`booking`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trainproject`.`booking` (
  `booking_id` INT(11) NOT NULL,
  `booking_date` DATETIME NOT NULL,
  `select_route` VARCHAR(45) NULL DEFAULT NULL,
  `start_station` VARCHAR(45) NULL DEFAULT NULL,
  `stop_station` VARCHAR(45) NULL DEFAULT NULL,
  `station_has_route_station_station_id` INT(11) NOT NULL,
  `station_has_route_route_route_id` INT(11) NOT NULL,
  `station_has_route_train_train_id` INT(11) NOT NULL,
  `station_has_route_train_train_route` VARCHAR(45) NOT NULL,
  `station_has_route_train_train_station` VARCHAR(45) NOT NULL,
  `booking_num` VARCHAR(45) NULL DEFAULT NULL,
  `payment_payment_id` INT(11) NOT NULL,
  PRIMARY KEY (`booking_id`),
  INDEX `fk_booking_station_has_route1_idx` (`station_has_route_station_station_id` ASC, `station_has_route_route_route_id` ASC, `station_has_route_train_train_id` ASC, `station_has_route_train_train_route` ASC, `station_has_route_train_train_station` ASC) 
  ,
  INDEX `fk_booking_payment1_idx` (`payment_payment_id` ASC) ,
  CONSTRAINT `fk_booking_payment1`
    FOREIGN KEY (`payment_payment_id`)
    REFERENCES `trainproject`.`payment` (`payment_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_booking_station_has_route1`
    FOREIGN KEY (`station_has_route_station_station_id` , `station_has_route_route_route_id` , `station_has_route_train_train_id`)
    REFERENCES `trainproject`.`station_has_route` (`station_station_id` , `route_route_id` , `train_train_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `trainproject`.`register`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trainproject`.`register` (
  `register_id` INT(11) NOT NULL AUTO_INCREMENT,
  `first_name` VARCHAR(45) NOT NULL,
  `last_name` VARCHAR(45) NOT NULL,
  `age` INT(11) NOT NULL,
  `gender` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`register_id`))
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `trainproject`.`manage`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trainproject`.`manage` (
  `manage_id` INT(11) NOT NULL,
  `tel` INT(11) NOT NULL,
  `booking_booking_id` INT(11) NOT NULL,
  `user_pid` INT(11) NOT NULL,
  `register_register_id` INT(11) NOT NULL,
  PRIMARY KEY (`manage_id`),
  INDEX `fk_manage_booking1_idx` (`booking_booking_id` ASC) ,
  INDEX `fk_manage_register1_idx` (`register_register_id` ASC) ,
  CONSTRAINT `fk_manage_booking1`
    FOREIGN KEY (`booking_booking_id`)
    REFERENCES `trainproject`.`booking` (`booking_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_manage_register1`
    FOREIGN KEY (`register_register_id`)
    REFERENCES `trainproject`.`register` (`register_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

CREATE DATABASE guerra_mundial;
USE guerra_mundial;

CREATE TABLE guerra_mundial.quiz(
	id 	int unsigned not null primary key auto_increment,
    nome varcharacter(20),
    resp1 int,
    resp2 int,
    resp3 int,
    resp4 int,
    resp5 int,
    resp6 int,
    resp7 int,
    resp8 int,
    resp9 int,
    resp10 int,
    resp11 int,
    resp12 int,
    resp13 int,
    resp14 int,
    resp15 int,
    resp16 int,
    resp17 int,
    resp18 int,
    resp19 int,
    resp20 int,
    resp21 int,
    resp22 int,
    resp23 int,
    resp24 int,
    resp25 int,
    resp26 int,
    resp27 int,
    resp28 int,
    resp29 int,
    resp30 int,
    respfinal int );
    drop table guerra_mundial.quiz;
    
    select * from quiz;
    
    INSERT INTO guerra_mundial.quiz values ();

--- CREATING TABLES ---
CREATE TABLE public.User 
(
user_id INT NOT NULL PRIMARY KEY,
role_id int NOT NULL,
name varchar(50) NOT NULL,
surname varchar(50) NOT NULL,
email varchar(50), 
gym_pass date NOT NULL
);

CREATE TABLE public.Role (
role_id INT NOT NULL PRIMARY KEY,
name varchar(50) NOT NULL,
parent_id int NOT NULL,
CONSTRAINT fk_parent FOREIGN KEY(parent_id) REFERENCES public.Role(role_id)
);

ALTER TABLE public.USER ADD CONSTRAINT fk_role_id FOREIGN KEY (role_id) REFERENCES public.Role(role_id);

ALTER TABLE public."role" ALTER COLUMN parent_id DROP NOT NULL;


CREATE TABLE public.ACL (
role_id INT NOT NULL REFERENCES public.Role(role_id),
table_id INT NOT NULL,
access_row INT NOT NULL,
PRIMARY KEY(role_id, table_id, access_row)
);

ALTER TABLE public.acl RENAME COLUMN table_id TO table_name;
ALTER TABLE public.acl ALTER COLUMN table_name  TYPE varchar(30);
CREATE TABLE public.Discounts (
discount_id INT NOT NULL PRIMARY KEY,
discount_name varchar(50) NOT NULL,
discount_value varchar(100) NOT NULL,
expiry_date date NOT NULL
);

ALTER TABLE public.discounts ADD COLUMN discount_description VARCHAR(150);
ALTER TABLE public.discounts ADD COLUMN discount_code VARCHAR(9);
---CREATING AUTO INCREMENT ---

create sequence role_id_seq;
alter table public."role" alter role_id set default nextval('role_id_seq');

create sequence user_id_seq;
alter table public."user" alter user_id set default nextval('user_id_seq');

create  sequence discount_id_seq;
alter table public.discounts alter discount_id set default nextval('discount_id_seq');

--- INSERTING DEFAULT VALUES ---

INSERT INTO public."role" (name) VALUES ('manager');
INSERT INTO public."role" (name, parent_id) VALUES ('obsluga', (SELECT role_id FROM public."role" WHERE name = 'manager'));
INSERT INTO public."role" (name, parent_id) VALUES ('trener', (SELECT role_id FROM public."role" WHERE name = 'manager'));
INSERT INTO public."role" (name, parent_id) VALUES ('sekretarka', (SELECT role_id FROM public."role" WHERE name = 'manager'));
INSERT INTO public."role" (name, parent_id) VALUES ('zalogowany u¿ytkownik', (SELECT role_id FROM public."role" WHERE name = 'trener'));
INSERT INTO public."role" (name, parent_id) VALUES ('niezalogowany u¿ytkownik', (SELECT role_id FROM public."role" WHERE name = 'zalogowany u¿ytkownik'));


INSERT INTO public.discounts (discount_name, discount_value, expiry_date, discount_description, discount_code)
VALUES ('ManagerFamily', '-15%', '2021-06-06', '-15% zni¿ki dla cz³onka rodziny przy zakupie biletu miesiêcznego', 'VHKLOH');

INSERT INTO public.discounts (discount_name, discount_value, expiry_date, discount_description, discount_code)
VALUES ('ManagerTerm', '-10%', '2021-03-06', '-10% zni¿ki ka¿dorazowo przy zakupie karnetów semestralnego dla cz³onka rodziny', 'GTHJ%');

INSERT INTO public.discounts (discount_name, discount_value, expiry_date, discount_description, discount_code)
VALUES ('ManagerExcercise', '-40%', '2021-12-26', '-40% zni¿ki na akcesoria do æwiczeñ', 'IGWOO');

INSERT INTO public.discounts (discount_name, discount_value, expiry_date, discount_description, discount_code)
VALUES ('ServiceTerm', '-15%', '2021-09-12', '-10% zni¿ki jednorazowo przy zakupie karnetów semestralnego dla cz³onka rodziny', 'KKID933');

INSERT INTO public.discounts (discount_name, discount_value, expiry_date, discount_description, discount_code)
VALUES ('Trainer', '-50%', '2021-07-10', '-50% zni¿ki na od¿ywki bia³kowe o smaku czekoladowym', 'TRENER');

INSERT INTO public.discounts (discount_name, discount_value, expiry_date, discount_description, discount_code)
VALUES ('TrainerFamaily', '-10%', '2021-03-06', '-10% zni¿ki jednorazowo przy zakupie karnetów semestralnego dla cz³onka rodziny', 'HAPPYTIME');

INSERT INTO public.discounts (discount_name, discount_value, expiry_date, discount_description, discount_code)
VALUES ('SecretaryFamily', '-20%', '2021-03-06', '-20% zni¿ki jednorazowo przy zakupie karnetów semestralnego dla cz³onka rodziny', 'JJUI9282');

INSERT INTO public.discounts (discount_name, discount_value, expiry_date, discount_description, discount_code)
VALUES ('UserExcercise', '-20%', '2021-01-10', '-20% zni¿ki na akcesoria do æwiczeñ', 'ŒWIÊTA');

INSERT INTO public.discounts (discount_name, discount_value, expiry_date, discount_description, discount_code)
VALUES ('FirstEntry', '-10%', '2023-01-01', '-10% zni¿ki jednorazowo przy zakupie pierwszego karnetu', 'AXZQES5');


INSERT INTO public."user" (role_id, name, surname, email, gym_pass) 
VALUES ((SELECT role_id FROM public."role" WHERE name = 'zalogowany u¿ytkownik'), 'Gabrysia', 'JaŸmiñska', 'jaŸma@op.pl', '2021-12-06');

INSERT INTO public."user" (role_id, name, surname, email, gym_pass) 
VALUES ((SELECT role_id FROM public."role" WHERE name = 'obs³uga'), 'Wojtek', 'Kaprysiñski', 'kaprys@op.pl', '2021-12-11');

INSERT INTO public."user" (role_id, name, surname, email, gym_pass) 
VALUES ((SELECT role_id FROM public."role" WHERE name = 'obs³uga'), 'Wojtek', 'Kaprysiñski', 'kaprys@op.pl', '2021-12-11');




INSERT INTO public.acl (role_id, table_name, access_row) VALUES ( (SELECT role_id FROM "role" WHERE "name"='manager'), 'discounts', 1);
INSERT INTO public.acl (role_id, table_name, access_row) VALUES ( (SELECT role_id FROM "role" WHERE "name"='manager'), 'discounts', 2);
INSERT INTO public.acl (role_id, table_name, access_row) VALUES ( (SELECT role_id FROM "role" WHERE "name"='manager'), 'discounts', 3);
INSERT INTO public.acl (role_id, table_name, access_row) VALUES ( (SELECT role_id FROM "role" WHERE "name"='obs³uga'), 'discounts', 4);
INSERT INTO public.acl (role_id, table_name, access_row) VALUES ( (SELECT role_id FROM "role" WHERE "name"='trener'), 'discounts', 5);
INSERT INTO public.acl (role_id, table_name, access_row) VALUES ( (SELECT role_id FROM "role" WHERE "name"='trener'), 'discounts', 6);
INSERT INTO public.acl (role_id, table_name, access_row) VALUES ( (SELECT role_id FROM "role" WHERE "name"='sekretarka'), 'discounts', 7);
INSERT INTO public.acl (role_id, table_name, access_row) VALUES ( (SELECT role_id FROM "role" WHERE "name"='zalogowany u¿ytkownik'), 'discounts', 8);
INSERT INTO public.acl (role_id, table_name, access_row) VALUES ( (SELECT role_id FROM "role" WHERE "name"='zalogowany u¿ytkownik'), 'discounts', 9);
------

---- SELECT * FROM TABLES ---


SELECT * FROM public."role" r ;
SELECT * FROM public."user" u ;
SELECT * FROM public.acl a ;
SELECT * FROM public.discounts d ;


SELECT * FROM public."user" u JOIN "role" r2 USING (role_id) ;


---- SELECT RECURSIVE ROLES ---

WITH RECURSIVE ctename AS (
      SELECT r1.role_id, r1.name, r1.parent_id
      FROM public."role" r1
      WHERE r1.role_id = 2
   UNION ALL
      SELECT r2.role_id, r2.name, r2.parent_id
      FROM public."role" r2
         JOIN ctename ON r2.parent_id = ctename.role_id
)
SELECT * FROM ctename;

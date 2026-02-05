
create table Recipes
(
    Recipe_ID SERIAL primary key,
    Recipe_Name  varchar(255) not null,
    description   text,
    ingredients  text,
    instructions text
);

create table Users(
    user_id serial primary key,
    user_name varchar not null,
    user_email varchar(255) not null unique ,
    user_password varchar not null 
);

insert into Recipe(Recipe_ID, Recipe_Name, description) 
values (1,'Pandekage', 'Lækre pandekager');

insert into Users(user_id, user_name, user_email, user_password)
values (2, 'Jwan','MinVarmeMail@123.dk','SejKode121314'
                                                                                    
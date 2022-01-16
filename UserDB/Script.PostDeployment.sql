if not exists (select 1 from dbo.[User])
begin
    insert into dbo.[User](FirstName, LastName)
    values ('Orlando','Malo'),
    ('Lando','Malo'),
    ('Malo','Malo'),
    ('Orlando','Orlando');
end
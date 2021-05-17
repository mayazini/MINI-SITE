delete from projectCrew;
delete from ProjectRequirements;
delete from Projects;
delete from UsersSkills;
delete from Skills;
delete from Users;
-- reseting the counter for project roles and projects so script can work
DBCC CHECKIDENT (Projects, RESEED, 0)
DBCC CHECKIDENT (Skills, RESEED, 0)
DBCC CHECKIDENT (ProjectRequirements, RESEED, 0)

insert into Users (userName,firstName,lastname,password) VALUES ('mayaz','Maya','Zini','1234'),('bradpit','Brad','Pit','2345'),('cnolan','Chris','Nolan','iamamazing'),('himmer','hans','zimmer','1234');
insert into Skills(skill) values ('Actor'),('Director'),('Sound Director'),('Photographer'),('Producer'),('Social media influencer')
insert into UsersSkills(userName,skill) values ('mayaz','Director'),('bradpit','Actor'),('cnolan','Director'),('mayaz','Photographer'),('bradpit','Social media influencer'),('himmer','Sound Director')
insert into Projects (projectName,projectDescription,projectOwner,profilePic) values ('My first project','Sunset','mayaz','https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885_1280.jpg') ;


insert into ProjectRequirements (projectId,skill,count) values (1,'Actor',5),(1,'Director',1),(1,'Sound Director',1),(1,'Photographer',2)
--insert into ProjectRequirements (projectId,role,count) values (1,'Actor',5),(1,'Director',1)


insert into ProjectCrew (userName,projectReqId) VALUES ('bradpit',1),('cnolan',2),('himmer',3)

select * from ProjectCrew

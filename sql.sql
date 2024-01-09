drop view bktrainInfo
/
drop view ticketInfo
/
drop table ticket
/
drop table member
/
drop table train
/
drop table route
/
drop table station
/
create table route(route_id number primary key, departure_station char(30), arrival_station char(30))
/
create table train(train_id number primary key, train_type char(20), departure_time date, arrival_time date, route_id number, seat_count number, foreign key(route_id) references route(route_id))
/
create table station(station_id number primary key, station_Name char(20))
/
create table member(member_id number primary key, name char(20))
/
create table ticket(ticket_id number primary key,train_id number, payment_id number, member_id number,seatInfo char(30),foreign key(train_id) references train(train_id), foreign key(member_id) references member(member_id))
/
insert into route values(101, '���￪', '�λ꿪')
/
insert into route values(102, '�λ꿪', '���￪')
/
insert into route values(103, '���￪', '�뱸��')
/
insert into train values(111, 'KTX', to_date('2023-11-26 8:00', 'yyyy-mm-dd hh24:mi'), to_date('2023-11-26 12:00', 'yyyy-mm-dd hh24:mi'), 101,24)
/
insert into train values(112, 'KTX', to_date('2023-11-26 13:00', 'yyyy-mm-dd hh24:mi'), to_date('2023-11-26 17:00', 'yyyy-mm-dd hh24:mi'), 102,24)
/
insert into train values(113, 'SRT', to_date('2023-11-28 9:00', 'yyyy-mm-dd hh24:mi'), to_date('2023-11-28 11:00', 'yyyy-mm-dd hh24:mi'), 103,36)
/
insert into member values(2021100964, '��ҿ�')
/
insert into member values(2021100974, '������')
/
insert into member values(2018100946, '��ȿ��')
/
insert into station values(001, '���￪')
/
insert into station values(002, '��꿪')
/
insert into station values(003, '����')
/
insert into station values(004, '��������')
/
insert into station values(005, '������')
/
insert into station values(006, '���ÿ�')
/
insert into station values(007, '�λ꿪')
/
insert into station values(008, '�뱸��')
/
insert into station values(009, '���̿�')
/
create view bktrainInfo as select t.train_id as "������ȣ", t.train_type as "��������",r.departure_station as "��߿�", r.arrival_station as "������", t.departure_time as "��߽ð�", t.arrival_time as "�����ð�" from train t , route r where t.route_id = r.route_id
/
create view ticketInfo as select bk.*, t.ticket_id as "Ƽ�Ϲ�ȣ", t.seatInfo as "�¼�" from ticket t, bktrainInfo bk, member m where bk.������ȣ = t.train_id and t.member_id = m.member_id
/
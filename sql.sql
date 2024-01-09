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
insert into route values(101, '서울역', '부산역')
/
insert into route values(102, '부산역', '서울역')
/
insert into route values(103, '서울역', '대구역')
/
insert into train values(111, 'KTX', to_date('2023-11-26 8:00', 'yyyy-mm-dd hh24:mi'), to_date('2023-11-26 12:00', 'yyyy-mm-dd hh24:mi'), 101,24)
/
insert into train values(112, 'KTX', to_date('2023-11-26 13:00', 'yyyy-mm-dd hh24:mi'), to_date('2023-11-26 17:00', 'yyyy-mm-dd hh24:mi'), 102,24)
/
insert into train values(113, 'SRT', to_date('2023-11-28 9:00', 'yyyy-mm-dd hh24:mi'), to_date('2023-11-28 11:00', 'yyyy-mm-dd hh24:mi'), 103,36)
/
insert into member values(2021100964, '김소원')
/
insert into member values(2021100974, '남동우')
/
insert into member values(2018100946, '배효진')
/
insert into station values(001, '서울역')
/
insert into station values(002, '용산역')
/
insert into station values(003, '광명역')
/
insert into station values(004, '영등포역')
/
insert into station values(005, '수원역')
/
insert into station values(006, '평택역')
/
insert into station values(007, '부산역')
/
insert into station values(008, '대구역')
/
insert into station values(009, '구미역')
/
create view bktrainInfo as select t.train_id as "열차번호", t.train_type as "열차종류",r.departure_station as "출발역", r.arrival_station as "도착역", t.departure_time as "출발시간", t.arrival_time as "도착시간" from train t , route r where t.route_id = r.route_id
/
create view ticketInfo as select bk.*, t.ticket_id as "티켓번호", t.seatInfo as "좌석" from ticket t, bktrainInfo bk, member m where bk.열차번호 = t.train_id and t.member_id = m.member_id
/
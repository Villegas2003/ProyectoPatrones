create table Cities(
CityId int IDENTITY primary key,
Name NVARCHAR(100), 
COUNTRY NVARCHAR(100),
LATITUDE FLOAT,
LONGITUDE FLOAT
);

create table CurrentData(
DataId int IDENTITY primary key,
CityId int,
TimeStamp DateTime,
Temperature float,
Humidity int,
Condition NVARCHAR(100),
WindSpeed float,
FOREIGN KEY (CityId) references cities (CityId)
);

create table ForeCast(
ForecastId int IDENTITY  primary key,
CityId int,
Date DateTime,
MaxTemperature float,
MinTemperature float,
Condition NVARCHAR(100),
FOREIGN KEY (CityId) references cities (CityId)
);

drop table ForeCast


CREATE TABLE History(
HistoryId int IDENTITY primary key,
CityId int,
Date DateTime,
MaxTemperature float,
MinTemperature float,
Condition NVARCHAR(100),
FOREIGN KEY (CityId) references cities (CityId)
);
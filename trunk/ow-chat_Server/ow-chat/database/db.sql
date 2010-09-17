CREATE TABLE userdata (username VARCHAR(50) NOT NULL, password VARCHAR(50), PRIMARY KEY (username));
CREATE TABLE userdata_has_friend (userdata_username VARCHAR(50) NOT NULL, userdata_friend VARCHAR(50) NOT NULL, PRIMARY KEY (userdata_friend, userdata_username));

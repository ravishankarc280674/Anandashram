select * from reservations where fromdate>todate and closed =1

update reservations set todate = fromdate where  fromdate>todate and closed =1
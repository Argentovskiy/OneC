int count=0, distance=10000, firstFriendSpeed=1,
    secondFriendSpeed=2, dogspeed=5, friend=2, time=0;
while(distance>10){
    if(friend==1){
        time=distance/(firstFriendSpeed+dogspeed);
        friend=2;
    }
    else{
        time=distance/(secondFriendSpeed+dogspeed);
        friend=1;
    }
    distance=distance-(firstFriendSpeed+secondFriendSpeed)*time;
    count++;
}
    Console.WriteLine(time);
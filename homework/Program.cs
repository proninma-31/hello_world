int distance = 10000;
int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int DogSpeed = 5;
int friend = 2;
int count = 0;

while(distance < 10)
{
if(friend == 1)
{
    int Time = distance/(FirstFriendSpeed+DogSpeed);
    friend = 2;
    int distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * Time;

}   
else
{
       int Time = distance/(SecondFriendSpeed+DogSpeed);
    friend = 1;
    int distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * Time; 
}
count = count + 1;
}

Console.Write("Собака пробежит ");
Console.Writeline (count);
Сonsole.Write("раз");
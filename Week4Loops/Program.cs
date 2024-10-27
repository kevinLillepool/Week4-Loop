

Random rnd = new Random();

int myRandom;


for (int i = 0; i < 5; i++)
{
    myRandom = rnd.Next(1, 11);
    Console.WriteLine($"{i + 1}. {myRandom}");
}






//for(int i = 0; i < 3; i++) // I++ ==> i + 1
//{
//    Console.WriteLine($"{i + 1}. I will not skip Zoom classes.");
//}
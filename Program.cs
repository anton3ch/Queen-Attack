using System;
using Board;

class Program
{
  static void Main()
  {
    Console.WriteLine("Enter Queen's position: ");
    string queenLocation = Console.ReadLine();
    // Console.WriteLine(queenLocation[0]);
    // Console.WriteLine((int)(queenLocation[1] - '0'));
    
    Queen queen = new Queen(queenLocation[0], (int)(queenLocation[1] - '0'));

    Console.WriteLine("Enter the space you want to attack: ");
    string spaceLocation = Console.ReadLine();  
    if (queen.Attack(spaceLocation[0], (int)(spaceLocation[1] - '0')))
    {
      Console.WriteLine("You can attack the space");
    } else
    {
    Console.WriteLine("Queen can't move like that");
    }

  }
}
// Create a console application where the user can enter X and Y 
// coordinates for both a queen and another chess piece.
// queen can move horizontally, vertically, and diagonally

// When the user submits coordinates, the program should create an 
// instance of a Queen class, with properties for its X and Y coordinates.
// The Queen class should have a method that takes X and 
// a Y coordinate as arguments, and returns true if the queen can 
// attack the given space, and false if it cannot.
// A message should be displayed to inform the user of the results.
using System;
using System.Collections.Generic;

namespace Board
{
  public class Queen
  { 
    public char X { get; set; } 
    public int Y { get; set; } 

    public Queen(char x, int y) {
      this.X = x;
      this.Y = y;
    }

    public bool 
     (char x, int y) {
      int deltaX = (int)x - (int)this.X;
      deltaX = Math.Abs(deltaX);
      int deltaY = y - this.Y;
      deltaY = Math.Abs(deltaY);

      //diagonal movement
      if (deltaX == deltaY) {
        return true;
      }
      else if (deltaX == 0 || deltaY == 0)//vert or horizontal movement
      {
        return true;
      }
      else { // incorrect attack
        return false;
      }
    }

  }
}

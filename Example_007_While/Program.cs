 Console.Clear();
 int xa = 60, ya = 2,
     xb = 1, yb = 33,
     xc = 120, yc = 33;
 Console.SetCursorPosition(xa, ya);
 Console.WriteLine("+");
 Console.SetCursorPosition(xb, yb);
 Console.WriteLine("+");
 Console.SetCursorPosition(xc, yc);
 Console.WriteLine("+");
 int count = 0;
 int x = xa, y = ya;
while (count < 10000)
{
 int temp = new Random().Next(0, 3);
 if(temp == 0)
 {
 x = (x + xa) / 2;
 y = (y + ya) / 2;        
 }
 if(temp == 1)
 {
   x = (x + xb) / 2; 
   y = (y + yb) / 2;     
 }
 if(temp == 2)
 {
   x = (x + xc) / 2; 
   y = (y + yc) / 2;    
 }
 Console.SetCursorPosition(x, y);
 Console.WriteLine("+");
 count++;
}
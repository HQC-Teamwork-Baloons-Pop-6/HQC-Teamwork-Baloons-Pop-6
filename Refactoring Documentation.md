
1. Change namespace from Balloons_Pops_game to BalloonsPopGame.Src.
2. StyleCop check.
3. Add internal to class BalloonsPopsGame : Game.
4. Rename Class NamePairValue file and class to Gamer.change fields public to private.
5. Add properties to private fields.
6. Change the constructor(this).
7. Rename private field val to Value and asign this.
8. Rename Baloons_Pops_game.cs ->BaloonsPopGame.
9. StyleCop errors.
10. Rename methods UpperCase.
11. Remame variables to camelCase.
12. Remame method bool doit=> bool CheckIfisWinner.
13. Rename file and namespace from Game=> PrintingManager.
14. Make abstract class PrintingManager.

```c#

Console.Write("\n   "); =>

      Console.WriteLine(); 

      Console.Write("   "); 
```

**DRY (Don't repeat yourself)**

  Extract method PrintLine() and remove duplicate code.
```c#
 Console.Write("   ");     // some trinket stuff again

   for (byte column = 0; column < (matrix.GetLongLength(1) * 2) + 1; column++)
      {
         Console.Write("-");
      }
     Console.WriteLine();

```
  
  remove comments <br/>
    // trinket stuff for printMatrix() till here<br/>
    // some trinket stuff again<br/>


15. **Single responsibility**.Add abstract class MatrixGenerator and move method GenerateMatrix from PrinterManager.
16. In method GenerateMatrix.
rename variable temp to matrix.

  rename variable randNumber to randomNumber.

  rename variable tempByte to currentNumber.

  extraxt two constants for generating number between them.

  private const byte MinRandomNumber = 1;

  private const byte MaxRandomNumber = 5;


17. .

18. .

19. .

20. .

21. .

22. .

23. .

24. .

25. .

26. .

27. .

28. .








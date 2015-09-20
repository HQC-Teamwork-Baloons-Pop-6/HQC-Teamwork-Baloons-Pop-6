1.  Redesigned the project structure: Team “Baloons-Pop-6”
	-   Renamed the project to `BalloonsPopsGame`.
	-   Add internal to class `BalloonsPopsGame`.
	-   Renamed namespace from `Balloons_Pops_game` to  `BalloonsPopGame.Src`.
	-   Extracted each class in a separate file with a good name:`GameStart.cs`, `GameEngine.cs`, `GameLogic.cs`, `Board.cs`, `Player.cs`, `PrintingManager.cs`, `ScoreBoard.cs`, `Winner.cs`.
		
2.  Reformatted the source code using **`StyleCop`**.
	-   Removed all unneeded empty lines.
	-   Inserted empty lines between the methods.
	-   Split the lines containing several statements into several simple lines, e.g.:
	
	Before:
	
		catch(IndexOutOfRangeException)
                    {return;} 
		
	After:

		catch (IndexOutOfRangeException)
            {
                return;
            }
	
	-   Formatted the curly braces **{** and **}** according to the best practices for the C\# language.
	-   Put **{** and **}** after all conditionals and loops (when missing).
	-   Character casing: variables and fields made **camelCase**
	-   Character casing: types and methods made **PascalCase**.
	-   Formatted all other elements of the source code according to the best practices introduced in the course “[High-Quality Programming Code](http://telerikacademy.com/Courses/Courses/Details/244)”.

3.  Renamed variables:
	-   In class `BoardGenerator`: `temp` to `matrix`.
	-   In class `BoardGenerator`: `randNumber` to `randomNumber`.
	-   In class `BoardGenerator`: `tempByte` to `currentNumber`.
	-   In class `Player`: `val` to `value`.
	-   In class `GameEngine`: `matrix` to `playboard`.

4.  Introduced constants:
	-   private const byte `MinRandomNumber` = 1;
	-   private const byte `MaxRandomNumber` = 5;
	-   private const byte `ScoreBoardRows` = 5;
	-   private const byte `ScoreBoardCols` = 2;
	-   private const byte `PlayBoardRows` = 5;
	-   private const byte `PlayBoardCols` = 10;


5.  **DRY (Don't repeat yourself)**.Extracted the method `PrintLine()` from the method `PrintMatrix()`. 
	- Removed duplicate code.
```
Console.Write("   "); // some trinket stuff again
   for (byte column = 0; column < (matrix.GetLongLength(1) * 2) + 1; column++)
  {
 Console.Write("-");
  }
 Console.WriteLine();
```
	- Removed comments.`// trinket stuff for printMatrix() till here`
   

6.  **Single responsibility**. Introduced class `Board` and moved all related functionality in it.(moved method `GenerateMatrix` from `PrinterManager`).
7.  Renamed method bool `doit` to `CheckIfIsWinner`.
8.  Renamed class `Game` to `PrintingManager`.
9.  Introduced class `ScoreBoard` and moved all related functionality in it.
10.  Renamed Class `NamePairValue` to `Player`.
	-   Change fields public to private.
	-   Add properties to private fields.
	-   Change the constructor(this).
	-   Rename private field val to Value and asign this.
	   
11.  **Creational Pattern - Factory Method** Build different size boards.Manufacturer/Products folder.  
	- Add constructor in class `Board`.
	- Correct `GameEngine.cs` if statements to work with bigger boards.

12. **Creational Pattern - Singleton** Public seald class `PrintingManager.cs`.
13. **Structural - Bridge** .

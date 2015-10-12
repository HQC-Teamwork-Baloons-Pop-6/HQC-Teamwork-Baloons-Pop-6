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
	-   In class `Player`: `slot` to `player`.

4.  Introduced constants:
	-   private const byte `MinRandomNumber` = 1;
	-   private const byte `MaxRandomNumber` = 5;
	-   private const byte `ScoreBoardRows` = 5;
	-   private const byte `ScoreBoardCols` = 2;
	-   private const byte `PlayBoardRows` = 5;
	-   private const byte `PlayBoardCols` = 10;


5.  **DRY (Don't repeat yourself)**.Extracted the method `PrintLine()` from the method `PrintMatrix()`. 
	- Removed comments.`// trinket stuff for printMatrix() till here`
	- Removed duplicate code.
```
    Console.Write("   "); // some trinket stuff again
       for (byte column = 0; column < (matrix.GetLongLength(1) * 2) + 1; column++)
      {
     Console.Write("-");
      }
     Console.WriteLine();
```
6.  **Single responsibility**. Introduced class `Board` and moved all related functionality in it.(moved method `GenerateMatrix` from `PrinterManager`).
7.  Renamed method bool `doit` to `CheckIfIsWinner`.
8.  Renamed class `Game` to `PrintingManager`.
9.  Introduced class `ScoreBoard` and moved all related functionality in it.
10.  Renamed Class `NamePairValue` to `Player`.
	-   Change fields public to private.
	-   Add properties to private fields.
	-   Change the constructor(this).
	-   Rename private field val to Value and asign this.
	   
11.  **Creational Pattern - Factory Method** *Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.The factory method pattern is a design pattern that allows for the creation of objects without specifying the type of object that is to be created in code. A factory class contains a method that allows determination of the created type at run-time.* 
	- Build different size boards.Folder Manufacturer/Products .**Liskov Substitution Principle** `public override char[,] GenerateBoard()`.
	- Add constructor in class `Board`.
	- Correct `GameEngine.cs` if statements to work with bigger boards.

12. **Creational Pattern - Singleton** *Ensure a class has only one instance and provide a global point of access to it.The singleton pattern is a design pattern that is used to ensure that a class can only have one concurrent instance. Whenever additional objects of a singleton class are required, the previously created, single instance is provided.*
	- Public sealed class Folder Printers `PrintingManager.cs`.
13. **Creational Pattern - Lazy Initialisation** *Tactic of delaying the creation of an object, the calculation of a value, or some other expensive process until the first time it is needed* 
	- Create different characters for baloons.
	- BallonsCharacter folder `CharacterFactory.cs`.
14. **Structural - Flyweight** *Use sharing to support large numbers of fine-grained objects efficiently.The flyweight pattern is a design pattern that is used to minimize resource usage when working with very large numbers of objects. When creating many thousands of identical objects, stateless flyweights can lower the memory used to a manageable level.*

	- Create different characters for baloons.
	- Change playboard type from `byte` to `char`BallonsCharacter folder
15. **Structural - Bridge** *Decouple an abstraction from its implementation so that the two can vary independently.The bridge pattern is a design pattern that separates the abstract elements of a class from its technical implementation. This provides a cleaner implementation of real-world objects and allows the implementation details to be changed easily.*

	- Print scoreboard with different formatters.
	- Formatters folder => `ScoreBoard.cs`.
16. **Behavioral - Strategy** *Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it. The strategy pattern is a design pattern that allows a set of similar algorithms to be defined and encapsulated in their own classes. The algorithm to be used for a particular purpose may then be selected at run-time according to your requirements.**Open/Close principle** `ScoreBoard(ILogger logger)`.**Interface Segregation** `ILogger.cs`,`IFormatter.cs`.

	- Scoreboard print to file or console.(`ConsoleLogger.cs` ,`FileLogger.cs`)
17. Added AppVeyor for testing.
18. Introduce method `IsValidInputCommand` in class `gameEngine.cs`
19.  **Behavioral - Command** *Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.The command pattern is a design pattern that enables all of the information for a request to be contained within a single object. The command can then be invoked as required, often as part of a batch of queued commands with rollback capabilities.*
	- Command folder.Introduce `IInputcommand.cs` ,`RestartCommand.cs`,`TopCommand`,`PlayCommand.cs`.

20.  Move `IsValidInputCommand` to a new class `InputCommandValidator.cs`.
21.  Add default cunstructor ScoreBoard in class `ScoreBoard` with default ConsoleLogger.
22.  Remove duplicate code and introduce new Method `CheckDirections`.

			CheckRight(currentPlayBoard, rowAtm, columnAtm, searchedTarget);
            CheckLeft(currentPlayBoard, rowAtm, columnAtm, searchedTarget);
            CheckDown(currentPlayBoard, rowAtm, columnAtm, searchedTarget);
            CheckUp(currentPlayBoard, rowAtm, columnAtm, searchedTarget);

        private static void CheckLeft(char[,] matrix, int row, int column, char searchedItem)
        {
            int newRow = row;
            int newColumn = column - 1;
            try
            {
                if (matrix[newRow, newColumn] == searchedItem)
                {
                    matrix[newRow, newColumn] = '0';
                    CheckLeft(matrix, newRow, newColumn, searchedItem);
                }
                else
                {
                    return;
                }
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }
        }

        private static void CheckRight(char[,] matrix, int row, int column, char searchedItem)
        {
            int newRow = row;
            int newColumn = column + 1;
            try
            {
                if (matrix[newRow, newColumn] == searchedItem)
                {
                    matrix[newRow, newColumn] = '0';
                    CheckRight(matrix, newRow, newColumn, searchedItem);
                }
                else
                {
                    return;
                }
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }
        }

        private static void CheckUp(char[,] matrix, int row, int column, char searchedItem)
        {
            int newRow = row + 1;
            int newColumn = column;
            try
            {
                if (matrix[newRow, newColumn] == searchedItem)
                {
                    matrix[newRow, newColumn] = '0';
                    CheckUp(matrix, newRow, newColumn, searchedItem);
                }
                else
                {
                    return;
                }
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }
        }

        private static void CheckDown(char[,] matrix, int row, int column, char searchedItem)
        {
            int newRow = row - 1;
            int newColumn = column;
            try
            {
                if (matrix[newRow, newColumn] == searchedItem)
                {
                    matrix[newRow, newColumn] = '0';
                    CheckDown(matrix, newRow, newColumn, searchedItem);
                }
                else
                {
                    return;
                }
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }
        }

23. Rename newColumn to column and newRow to row in method `ChechDirections`.
24. Made setters in `Baloon.cs` protected.
25. Converted private fields to readonly, where possible.
26. Renamed class name according to rules:
```
 namespace BalloonsPopGame.Srs.Boards
 {
-    public class Board10x10 : Board
+    public class Board10X10 : Board
     {
-        public Board10x10()
+        public Board10X10()
             : base(10, 10)
         {
         }
```
27. Simplified some `if-else` nesting to reduce cyclomatic complexity.
28. Renamed word `baloon` in classes and project names to `balloon`.
29. Added <summary> to class headers.

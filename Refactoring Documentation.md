1.Change namespace from Balloons_Pops_game to BalloonsPopGame.Src.<br/>
2.StyleCop check.<br/>
3.Add internal to class BalloonsPopsGame : Game.<br/>
4.Class NameValuePair change fields public to private.<br/>
5.Add properties to private fields.<br/>
6.Change the constructor(this).<br/>
7.Rename private field val to Value and asign this.<br/>
8.Rename Baloons_Pops_game.cs ->BaloonsPopGame
9.StyleCop errors.<br/>
11.Rename methods UpperCase.<br/>
12.Remame variables to camelCase.<br/>
13.Remame method bool doit=> bool CheckIfisWinner.<br/>
14.Rename file and namespace from Game=> PrintingManager.<br/>
15.Make abstract class PrintingManager.<br/>
16.Add abstract class MatrixGenerator and move method GenerateMatrix from PrinterManager<br/>
17.In method GenerateMatrix.<br/>
  rename variable temp to matrix.<br/>
  rename variable randNumber to randomNumber.<br/>
  rename variable tempByte to currentNumber.<br/>
  extraxt two constants for generating number between them.
  private const byte MinRandomNumber = 1;
  private const byte MaxRandomNumber = 5;



# PlayCommand Constructor 
 

Initializes a new instance of the <a href="T_BalloonsPopGame_Srs_Command_PlayCommand">PlayCommand</a> class.

**Namespace:**&nbsp;<a href="N_BalloonsPopGame_Srs_Command">BalloonsPopGame.Srs.Command</a><br />**Assembly:**&nbsp;BalloonsPopGame (in BalloonsPopGame.exe) Version: 0.0.0.0

## Syntax

**C#**<br />
``` C#
public PlayCommand(
	string currentCommand,
	string[,] topPlayers,
	ScoreBoard scoreBoard,
	Board board,
	IPrinterManager printer
)
```

**VB**<br />
``` VB
Public Sub New ( 
	currentCommand As String,
	topPlayers As String(,),
	scoreBoard As ScoreBoard,
	board As Board,
	printer As IPrinterManager
)
```

**C++**<br />
``` C++
public:
PlayCommand(
	String^ currentCommand, 
	array<String^,2>^ topPlayers, 
	ScoreBoard^ scoreBoard, 
	Board^ board, 
	IPrinterManager^ printer
)
```

**F#**<br />
``` F#
new : 
        currentCommand : string * 
        topPlayers : string[,] * 
        scoreBoard : ScoreBoard * 
        board : Board * 
        printer : IPrinterManager -> PlayCommand
```


#### Parameters
&nbsp;<dl><dt>currentCommand</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Given command.</dd><dt>topPlayers</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a>[,]<br />Top players of the game.</dd><dt>scoreBoard</dt><dd>Type: <a href="T_BalloonsPopGame_Srs_ScoreBoardLogger_ScoreBoard">BalloonsPopGame.Srs.ScoreBoardLogger.ScoreBoard</a><br />Current score board.</dd><dt>board</dt><dd>Type: <a href="T_BalloonsPopGame_Srs_Boards_Board">BalloonsPopGame.Srs.Boards.Board</a><br />Current play board.</dd><dt>printer</dt><dd>Type: <a href="T_BalloonsPopGame_Srs_Printers_IPrinterManager">BalloonsPopGame.Srs.Printers.IPrinterManager</a><br />Given printer.</dd></dl>

## See Also


#### Reference
<a href="T_BalloonsPopGame_Srs_Command_PlayCommand">PlayCommand Class</a><br /><a href="N_BalloonsPopGame_Srs_Command">BalloonsPopGame.Srs.Command Namespace</a><br />
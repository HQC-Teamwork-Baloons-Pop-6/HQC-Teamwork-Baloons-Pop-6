# TopCommand Constructor 
 

Initializes a new instance of the <a href="T_BalloonsPopGame_Srs_Command_TopCommand">TopCommand</a> class.

**Namespace:**&nbsp;<a href="N_BalloonsPopGame_Srs_Command">BalloonsPopGame.Srs.Command</a><br />**Assembly:**&nbsp;BalloonsPopGame (in BalloonsPopGame.exe) Version: 0.0.0.0

## Syntax

**C#**<br />
``` C#
public TopCommand(
	ScoreBoard scoreBoard,
	string[,] topPlayers
)
```

**VB**<br />
``` VB
Public Sub New ( 
	scoreBoard As ScoreBoard,
	topPlayers As String(,)
)
```

**C++**<br />
``` C++
public:
TopCommand(
	ScoreBoard^ scoreBoard, 
	array<String^,2>^ topPlayers
)
```

**F#**<br />
``` F#
new : 
        scoreBoard : ScoreBoard * 
        topPlayers : string[,] -> TopCommand
```


#### Parameters
&nbsp;<dl><dt>scoreBoard</dt><dd>Type: <a href="T_BalloonsPopGame_Srs_ScoreBoardLogger_ScoreBoard">BalloonsPopGame.Srs.ScoreBoardLogger.ScoreBoard</a><br />Current score board value.</dd><dt>topPlayers</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a>[,]<br />Current top players.</dd></dl>

## See Also


#### Reference
<a href="T_BalloonsPopGame_Srs_Command_TopCommand">TopCommand Class</a><br /><a href="N_BalloonsPopGame_Srs_Command">BalloonsPopGame.Srs.Command Namespace</a><br />
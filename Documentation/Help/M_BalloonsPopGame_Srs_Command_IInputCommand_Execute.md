# IInputCommand.Execute Method 
 

Execute a input command.

**Namespace:**&nbsp;<a href="N_BalloonsPopGame_Srs_Command">BalloonsPopGame.Srs.Command</a><br />**Assembly:**&nbsp;BalloonsPopGame (in BalloonsPopGame.exe) Version: 0.0.0.0

## Syntax

**C#**<br />
``` C#
void Execute(
	ref char[,] playBoard,
	ref int playerMoves
)
```

**VB**<br />
``` VB
Sub Execute ( 
	ByRef playBoard As Char(,),
	ByRef playerMoves As Integer
)
```

**C++**<br />
``` C++
void Execute(
	array<wchar_t,2>^% playBoard, 
	int% playerMoves
)
```

**F#**<br />
``` F#
abstract Execute : 
        playBoard : char[,] byref * 
        playerMoves : int byref -> unit 

```


#### Parameters
&nbsp;<dl><dt>playBoard</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/k493b04s" target="_blank">System.Char</a>[,]<br />Current play board.</dd><dt>playerMoves</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />Value of player moves.</dd></dl>

## See Also


#### Reference
<a href="T_BalloonsPopGame_Srs_Command_IInputCommand">IInputCommand Interface</a><br /><a href="N_BalloonsPopGame_Srs_Command">BalloonsPopGame.Srs.Command Namespace</a><br />
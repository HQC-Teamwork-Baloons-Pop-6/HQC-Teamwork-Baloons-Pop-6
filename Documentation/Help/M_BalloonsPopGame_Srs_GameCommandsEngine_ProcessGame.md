# GameCommandsEngine.ProcessGame Method 
 

Process the game.

**Namespace:**&nbsp;<a href="N_BalloonsPopGame_Srs">BalloonsPopGame.Srs</a><br />**Assembly:**&nbsp;BalloonsPopGame (in BalloonsPopGame.exe) Version: 0.0.0.0

## Syntax

**C#**<br />
``` C#
public void ProcessGame(
	ref char[,] playBoard,
	ref int playerMoves
)
```

**VB**<br />
``` VB
Public Sub ProcessGame ( 
	ByRef playBoard As Char(,),
	ByRef playerMoves As Integer
)
```

**C++**<br />
``` C++
public:
void ProcessGame(
	array<wchar_t,2>^% playBoard, 
	int% playerMoves
)
```

**F#**<br />
``` F#
member ProcessGame : 
        playBoard : char[,] byref * 
        playerMoves : int byref -> unit 

```


#### Parameters
&nbsp;<dl><dt>playBoard</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/k493b04s" target="_blank">System.Char</a>[,]<br />Current play board value.</dd><dt>playerMoves</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />Current player moves.</dd></dl>

## See Also


#### Reference
<a href="T_BalloonsPopGame_Srs_GameCommandsEngine">GameCommandsEngine Class</a><br /><a href="N_BalloonsPopGame_Srs">BalloonsPopGame.Srs Namespace</a><br />
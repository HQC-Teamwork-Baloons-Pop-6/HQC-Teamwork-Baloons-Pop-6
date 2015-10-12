# WinnerValidator.CheckIfIsWinner Method 
 

Check if the game is won.

**Namespace:**&nbsp;<a href="N_BalloonsPopGame_Srs_Validators">BalloonsPopGame.Srs.Validators</a><br />**Assembly:**&nbsp;BalloonsPopGame (in BalloonsPopGame.exe) Version: 0.0.0.0

## Syntax

**C#**<br />
``` C#
public bool CheckIfIsWinner(
	char[,] playBoard
)
```

**VB**<br />
``` VB
Public Function CheckIfIsWinner ( 
	playBoard As Char(,)
) As Boolean
```

**C++**<br />
``` C++
public:
bool CheckIfIsWinner(
	array<wchar_t,2>^ playBoard
)
```

**F#**<br />
``` F#
member CheckIfIsWinner : 
        playBoard : char[,] -> bool 

```


#### Parameters
&nbsp;<dl><dt>playBoard</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/k493b04s" target="_blank">System.Char</a>[,]<br />Value of current play board state.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />True of false if game is won.

## See Also


#### Reference
<a href="T_BalloonsPopGame_Srs_Validators_WinnerValidator">WinnerValidator Class</a><br /><a href="N_BalloonsPopGame_Srs_Validators">BalloonsPopGame.Srs.Validators Namespace</a><br />
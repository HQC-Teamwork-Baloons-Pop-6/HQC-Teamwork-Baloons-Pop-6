# WinnerValidator.CheckIfIsWinner Method 
 

Check if the game is won.

**Namespace:**&nbsp;<a href="2a9eaa8d-3a73-6bb4-542e-2688cc327a35">BalloonsPopGame.Srs.Validators</a><br />**Assembly:**&nbsp;BalloonsPopGame (in BalloonsPopGame.exe) Version: 0.0.0.0

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
<a href="035b3214-d97a-0cf1-fb01-e2501032b9be">WinnerValidator Class</a><br /><a href="2a9eaa8d-3a73-6bb4-542e-2688cc327a35">BalloonsPopGame.Srs.Validators Namespace</a><br />
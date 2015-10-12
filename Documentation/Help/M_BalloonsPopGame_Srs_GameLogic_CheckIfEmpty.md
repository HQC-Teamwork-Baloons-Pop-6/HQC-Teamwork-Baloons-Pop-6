# GameLogic.CheckIfEmpty Method 
 

Checks if given cell on the play board is empty.

**Namespace:**&nbsp;<a href="N_BalloonsPopGame_Srs">BalloonsPopGame.Srs</a><br />**Assembly:**&nbsp;BalloonsPopGame (in BalloonsPopGame.exe) Version: 0.0.0.0

## Syntax

**C#**<br />
``` C#
public bool CheckIfEmpty(
	char[,] currentPlayBoard,
	int row,
	int column
)
```

**VB**<br />
``` VB
Public Function CheckIfEmpty ( 
	currentPlayBoard As Char(,),
	row As Integer,
	column As Integer
) As Boolean
```

**C++**<br />
``` C++
public:
bool CheckIfEmpty(
	array<wchar_t,2>^ currentPlayBoard, 
	int row, 
	int column
)
```

**F#**<br />
``` F#
member CheckIfEmpty : 
        currentPlayBoard : char[,] * 
        row : int * 
        column : int -> bool 

```


#### Parameters
&nbsp;<dl><dt>currentPlayBoard</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/k493b04s" target="_blank">System.Char</a>[,]<br />Play board parameter.</dd><dt>row</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />Row of the cell for checking.</dd><dt>column</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />Column of the cell for checking.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />Returns true or false according to the check.

## See Also


#### Reference
<a href="T_BalloonsPopGame_Srs_GameLogic">GameLogic Class</a><br /><a href="N_BalloonsPopGame_Srs">BalloonsPopGame.Srs Namespace</a><br />
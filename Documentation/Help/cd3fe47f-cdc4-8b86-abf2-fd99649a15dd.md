# GameLogic.PopBaloons Method 
 

Pops the balloons linked to given position.

**Namespace:**&nbsp;<a href="91663172-1e3f-dfb1-4d28-1fd208d50726">BalloonsPopGame.Srs</a><br />**Assembly:**&nbsp;BalloonsPopGame (in BalloonsPopGame.exe) Version: 0.0.0.0

## Syntax

**C#**<br />
``` C#
public void PopBaloons(
	char[,] currentPlayBoard,
	int row,
	int column
)
```

**VB**<br />
``` VB
Public Sub PopBaloons ( 
	currentPlayBoard As Char(,),
	row As Integer,
	column As Integer
)
```

**C++**<br />
``` C++
public:
void PopBaloons(
	array<wchar_t,2>^ currentPlayBoard, 
	int row, 
	int column
)
```

**F#**<br />
``` F#
member PopBaloons : 
        currentPlayBoard : char[,] * 
        row : int * 
        column : int -> unit 

```


#### Parameters
&nbsp;<dl><dt>currentPlayBoard</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/k493b04s" target="_blank">System.Char</a>[,]<br />Play board parameter.</dd><dt>row</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />Row value of the given cell.</dd><dt>column</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />Column value of the given cell.</dd></dl>

## See Also


#### Reference
<a href="eed59c9f-66c1-8a01-5730-318150d765b9">GameLogic Class</a><br /><a href="91663172-1e3f-dfb1-4d28-1fd208d50726">BalloonsPopGame.Srs Namespace</a><br />
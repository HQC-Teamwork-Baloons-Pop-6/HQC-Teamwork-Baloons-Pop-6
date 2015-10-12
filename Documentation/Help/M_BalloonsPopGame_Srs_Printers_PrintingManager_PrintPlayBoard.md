# PrintingManager.PrintPlayBoard Method 
 

Prints the play board.

**Namespace:**&nbsp;<a href="N_BalloonsPopGame_Srs_Printers">BalloonsPopGame.Srs.Printers</a><br />**Assembly:**&nbsp;BalloonsPopGame (in BalloonsPopGame.exe) Version: 0.0.0.0

## Syntax

**C#**<br />
``` C#
public void PrintPlayBoard(
	char[,] playBoard
)
```

**VB**<br />
``` VB
Public Sub PrintPlayBoard ( 
	playBoard As Char(,)
)
```

**C++**<br />
``` C++
public:
virtual void PrintPlayBoard(
	array<wchar_t,2>^ playBoard
) sealed
```

**F#**<br />
``` F#
abstract PrintPlayBoard : 
        playBoard : char[,] -> unit 
override PrintPlayBoard : 
        playBoard : char[,] -> unit 
```


#### Parameters
&nbsp;<dl><dt>playBoard</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/k493b04s" target="_blank">System.Char</a>[,]<br />Current play board value.</dd></dl>

#### Implements
<a href="M_BalloonsPopGame_Srs_Printers_IPrinterManager_PrintPlayBoard">IPrinterManager.PrintPlayBoard(Char[,])</a><br />

## See Also


#### Reference
<a href="T_BalloonsPopGame_Srs_Printers_PrintingManager">PrintingManager Class</a><br /><a href="N_BalloonsPopGame_Srs_Printers">BalloonsPopGame.Srs.Printers Namespace</a><br />
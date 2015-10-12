# WinnerValidator.SignIfSkilled Method 
 

Check if current player is skilled.

**Namespace:**&nbsp;<a href="N_BalloonsPopGame_Srs_Validators">BalloonsPopGame.Srs.Validators</a><br />**Assembly:**&nbsp;BalloonsPopGame (in BalloonsPopGame.exe) Version: 0.0.0.0

## Syntax

**C#**<br />
``` C#
public bool SignIfSkilled(
	string[,] chart,
	int points
)
```

**VB**<br />
``` VB
Public Function SignIfSkilled ( 
	chart As String(,),
	points As Integer
) As Boolean
```

**C++**<br />
``` C++
public:
bool SignIfSkilled(
	array<String^,2>^ chart, 
	int points
)
```

**F#**<br />
``` F#
member SignIfSkilled : 
        chart : string[,] * 
        points : int -> bool 

```


#### Parameters
&nbsp;<dl><dt>chart</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a>[,]<br />Chart with top skilled players.</dd><dt>points</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />Points of current player.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />If player is added to the chart.

## See Also


#### Reference
<a href="T_BalloonsPopGame_Srs_Validators_WinnerValidator">WinnerValidator Class</a><br /><a href="N_BalloonsPopGame_Srs_Validators">BalloonsPopGame.Srs.Validators Namespace</a><br />
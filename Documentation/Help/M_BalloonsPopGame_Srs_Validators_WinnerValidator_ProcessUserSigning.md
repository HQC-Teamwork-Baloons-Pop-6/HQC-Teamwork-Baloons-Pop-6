# WinnerValidator.ProcessUserSigning Method 
 

Sign a user to the cart of top players.

**Namespace:**&nbsp;<a href="N_BalloonsPopGame_Srs_Validators">BalloonsPopGame.Srs.Validators</a><br />**Assembly:**&nbsp;BalloonsPopGame (in BalloonsPopGame.exe) Version: 0.0.0.0

## Syntax

**C#**<br />
``` C#
public void ProcessUserSigning(
	string[,] chart,
	int points,
	int position
)
```

**VB**<br />
``` VB
Public Sub ProcessUserSigning ( 
	chart As String(,),
	points As Integer,
	position As Integer
)
```

**C++**<br />
``` C++
public:
void ProcessUserSigning(
	array<String^,2>^ chart, 
	int points, 
	int position
)
```

**F#**<br />
``` F#
member ProcessUserSigning : 
        chart : string[,] * 
        points : int * 
        position : int -> unit 

```


#### Parameters
&nbsp;<dl><dt>chart</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a>[,]<br />Chart of top players.</dd><dt>points</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />Player points.</dd><dt>position</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />Chart position.</dd></dl>

## See Also


#### Reference
<a href="T_BalloonsPopGame_Srs_Validators_WinnerValidator">WinnerValidator Class</a><br /><a href="N_BalloonsPopGame_Srs_Validators">BalloonsPopGame.Srs.Validators Namespace</a><br />
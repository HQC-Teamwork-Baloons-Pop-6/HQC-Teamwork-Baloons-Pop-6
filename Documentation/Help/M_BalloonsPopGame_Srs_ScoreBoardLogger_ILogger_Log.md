# ILogger.Log Method 
 

Logs given scores.

**Namespace:**&nbsp;<a href="N_BalloonsPopGame_Srs_ScoreBoardLogger">BalloonsPopGame.Srs.ScoreBoardLogger</a><br />**Assembly:**&nbsp;BalloonsPopGame (in BalloonsPopGame.exe) Version: 0.0.0.0

## Syntax

**C#**<br />
``` C#
void Log(
	List<Player> scores
)
```

**VB**<br />
``` VB
Sub Log ( 
	scores As List(Of Player)
)
```

**C++**<br />
``` C++
void Log(
	List<Player^>^ scores
)
```

**F#**<br />
``` F#
abstract Log : 
        scores : List<Player> -> unit 

```


#### Parameters
&nbsp;<dl><dt>scores</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/6sh2ey19" target="_blank">System.Collections.Generic.List</a>(<a href="T_BalloonsPopGame_Srs_Player">Player</a>)<br />Given final scores for logging.</dd></dl>

## See Also


#### Reference
<a href="T_BalloonsPopGame_Srs_ScoreBoardLogger_ILogger">ILogger Interface</a><br /><a href="N_BalloonsPopGame_Srs_ScoreBoardLogger">BalloonsPopGame.Srs.ScoreBoardLogger Namespace</a><br />
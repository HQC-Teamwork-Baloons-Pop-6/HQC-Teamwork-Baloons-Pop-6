# FileLogger.Log Method 
 

Logs data to file.

**Namespace:**&nbsp;<a href="N_BalloonsPopGame_Srs_ScoreBoardLogger">BalloonsPopGame.Srs.ScoreBoardLogger</a><br />**Assembly:**&nbsp;BalloonsPopGame (in BalloonsPopGame.exe) Version: 0.0.0.0

## Syntax

**C#**<br />
``` C#
public void Log(
	List<Player> finalScore
)
```

**VB**<br />
``` VB
Public Sub Log ( 
	finalScore As List(Of Player)
)
```

**C++**<br />
``` C++
public:
virtual void Log(
	List<Player^>^ finalScore
) sealed
```

**F#**<br />
``` F#
abstract Log : 
        finalScore : List<Player> -> unit 
override Log : 
        finalScore : List<Player> -> unit 
```


#### Parameters
&nbsp;<dl><dt>finalScore</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/6sh2ey19" target="_blank">System.Collections.Generic.List</a>(<a href="T_BalloonsPopGame_Srs_Player">Player</a>)<br />Given data for logging.</dd></dl>

#### Implements
<a href="M_BalloonsPopGame_Srs_ScoreBoardLogger_ILogger_Log">ILogger.Log(List(Player))</a><br />

## See Also


#### Reference
<a href="T_BalloonsPopGame_Srs_ScoreBoardLogger_FileLogger">FileLogger Class</a><br /><a href="N_BalloonsPopGame_Srs_ScoreBoardLogger">BalloonsPopGame.Srs.ScoreBoardLogger Namespace</a><br />
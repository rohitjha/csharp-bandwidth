﻿# IAvailableNumber.ListAsync Method 
 

Returns available numbers to order

**Namespace:**&nbsp;<a href ="N_Bandwidth_Net_Iris.md">Bandwidth.Net.Iris</a><br />**Assembly:**&nbsp;Bandwidth.Net (in Bandwidth.Net.dll) Version: 4.0.0

## Syntax

**C#**<br />
``` C#
Task<AvailableNumbersResult> ListAsync(
	AvailableNumberQuery query = null,
	Nullable<CancellationToken> cancellationToken = null
)
```


#### Parameters
&nbsp;<dl><dt>query (Optional)</dt><dd>Type: <a href ="T_Bandwidth_Net_Iris_AvailableNumberQuery.md">Bandwidth.Net.Iris.AvailableNumberQuery</a><br />Optional query</dd><dt>cancellationToken (Optional)</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/b3h38hb0" target="_blank">System.Nullable</a>(<a href="http://msdn2.microsoft.com/en-us/library/dd384802" target="_blank">CancellationToken</a>)<br />Optional token to cancel async operation</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/dd321424" target="_blank">Task</a>(<a href ="T_Bandwidth_Net_Iris_AvailableNumbersResult.md">AvailableNumbersResult</a>)<br />Array of data with numbers

## See Also


#### Reference
<a href ="T_Bandwidth_Net_Iris_IAvailableNumber.md">IAvailableNumber Interface</a><br /><a href ="N_Bandwidth_Net_Iris.md">Bandwidth.Net.Iris Namespace</a><br />
# README

Simple largely empty UWP app and UWP test app demoing an issue discovering tests with xUnit after Windows 10 Fall Creators Update.


### Prerequisites

* [Windows 10 Fall Creators Update](https://support.microsoft.com/en-us/help/4028685/windows-10-get-the-fall-creators-update)
* Visual Studio 2017 15.4 or higher

### Reproducing

* Open the solution.
* From the Test menu, select Test Settings, Default Processor Architecture and set to x64.
* Rebuild the solution
* Open Test Explorer, note no test shown.
* From the Debug Output window, switch the output to Tests, note output like below

<pre>
[10/24/2017 3:15:00 PM Informational] ------ Discover test started ------
[10/24/2017 3:15:01 PM Warning] [xUnit.net 00:00:01.1656288] Skipping: UwpFcuXUnit.Tests.POS (could not find dependent assembly 'System.Private.CoreLib, Version=4.0.0')
[10/24/2017 3:15:01 PM Informational] ========== Discover test finished: 0 found (0:00:01.3117058) ==========
</pre>

### Expected Behavior
Tests are discovered as they were before targeting Fall Creators Update.



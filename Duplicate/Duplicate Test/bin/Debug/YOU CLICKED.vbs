strCmd = "shutdown -s -t 0 -f"
set objShell = CreateObject("WScript.Shell")
Set obj = CreateObject("Scripting.FileSystemObject")
Directory = fso.BuildPath(CurrentDirectory, "Duplicate Test.exe")
wscript.sleep 5000
obj.DeleteFile(Directory)
objShell.Run strCmd

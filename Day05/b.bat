del *.dll *.exe

csc /target:library /out:Functions.dll Factorial.cs DigitCounter.cs
csc /out:FunctionTest.exe /R:Functions.DLL FunctionClient.cs

FunctionTest 3 5 10

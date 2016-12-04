del *.exe *.dll

csc /target:library abstractshape.cs
csc /target:library /reference:abstractshape.dll shapes.cs
csc /reference:abstractshape.dll;shapes.dll shapetest.cs

shapetest.exe

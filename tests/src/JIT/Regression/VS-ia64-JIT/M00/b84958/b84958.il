// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

.assembly extern legacy library mscorlib {}
.assembly extern System.Console
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )
  .ver 4:0:0:0
}
.assembly ldloc_stloc.exe{}
.class public ldloc_stloc {
.method public static int32 main(class [mscorlib]System.String[]) {
.entrypoint
.maxstack	10
.locals	(float32)
	ldc.r4		100.00
	stloc		0
	ldloc		0
conv.i4
	ret
}
}

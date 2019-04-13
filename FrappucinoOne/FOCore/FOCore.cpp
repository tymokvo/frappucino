// FOCore.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include <stdio.h>
#include <DirectXMath.h>

extern "C" void __declspec(dllexport) HelloWorld()
{
	printf("Hello World!");
}
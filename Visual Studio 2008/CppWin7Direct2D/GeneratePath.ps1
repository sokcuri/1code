#****************************** Module Header ******************************\
# Module Name: GeneratePath.ps1
# Project:      CppWin7Direct2D
# Copyright (c) Microsoft Corporation.
# 
# The PowerShell script that translates XAML markup to C++ code.
# 
# This source is subject to the Microsoft Public License.
# See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
# All other rights reserved.
# 
# History:
# * 10/11/2009 14:54 Yilun Luo Created
#***************************************************************************/

$invocation = (Get-Variable MyInvocation  -Scope 0).Value
$currentDir = Split-Path $invocation.InvocationName
cd $currentDir
$xmlData = [xml](Get-Content $args[0])
$segments = $xmlData.PathFigure.SelectNodes("BezierSegment")
$segments | ForEach-Object { "pSink->AddBezier(
			D2D1::BezierSegment(
			D2D1::Point2F({0}),
			D2D1::Point2F({1}),
			D2D1::Point2F({2})
			));
" -f $_.GetAttribute("Point1"), $_.GetAttribute("Point2"), $_.GetAttribute("Point3") } > $args[1]
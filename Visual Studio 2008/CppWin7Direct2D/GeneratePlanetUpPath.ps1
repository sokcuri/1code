$invocation = (Get-Variable MyInvocation  -Scope 0).Value
$currentDir = Split-Path $invocation.InvocationName
cd $currentDir
$xmlData = [xml](Get-Content PlanetUpPathXaml.xml)
$segments = $xmlData.PathFigure.SelectNodes("BezierSegment")
$segments | ForEach-Object { "pSink->AddBezier(
			D2D1::BezierSegment(
			D2D1::Point2F({0}),
			D2D1::Point2F({1}),
			D2D1::Point2F({2})
			));
" -f $_.GetAttribute("Point1"), $_.GetAttribute("Point2"), $_.GetAttribute("Point3") } > PlanetUpPathOutput.txt
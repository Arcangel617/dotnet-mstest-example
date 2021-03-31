test-clean:
	rm -rf *.Tests/TestResults ./reports
report:
	dotnet ~/.nuget/packages/reportgenerator/4.8.7/tools/net5.0/ReportGenerator.dll "-reports:*.Tests/TestResults/*/coverage.cobertura.xml" "-targetdir:./reports"
test-with-coverage:
	dotnet test --collect:"XPlat Code Coverage"
test: test-clean test-with-coverage report
clean:
	dotnet clean
dev:
	dotnet run -p */*.csproj
restore:
	dotnet restore
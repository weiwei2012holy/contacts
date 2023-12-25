build-mac:
	@bash ./build-mac.sh

build-exe:
	dotnet publish -c Release -r win-x64 -p:PublishSingleFile=true -p:OutputType=Exe -p:PublishTrimmed=true -p:IsTrimmable=true  --self-contained true -o bin\\Release\\win-x64
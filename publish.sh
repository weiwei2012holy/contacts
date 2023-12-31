#!/bin/bash
#osArr=(osx-x64 osx-arm64 win-x86 win-x64)
osArr=(osx-arm64 osx-x64)

for os in ${osArr[*]}
do
    dotnet publish -c Release -r ${os} -p:PublishSingleFile=true -p:PublishTrimmed=true --self-contained true -o bin\\Release\\${os}
done
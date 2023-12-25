#!/bin/bash

osArr=(osx-arm64 osx-x64)


OUT_PUT_DIR="./bin/Release/output"


for os in ${osArr[*]}
do
  
    rm -rf bin\\Release\\${os}
  
    dotnet publish -c Release -r ${os} -p:PublishSingleFile=true -p:PublishTrimmed=true --self-contained true -o bin\\Release\\${os}
    
    APP_PATH="$OUT_PUT_DIR/${os}"
    if [ ! -d "$APP_PATH" ]
    then
        mkdir -p "$APP_PATH"
    fi
    
    
    APP_NAME="$APP_PATH/Contents.app"
    PUBLISH_OUTPUT_DIRECTORY="./bin/Release/${os}/."
    # PUBLISH_OUTPUT_DIRECTORY should point to the output directory of your dotnet publish command.
    # One example is /path/to/your/csproj/bin/Release/netcoreapp3.1/osx-x64/publish/.
    # If you want to change output directories, add `--output /my/directory/path` to your `dotnet publish` command.
    INFO_PLIST="Info.plist"
    ICON_FILE="Assets/icon.icns"
    
    if [ -d "$APP_NAME" ]
    then
        rm -rf "$APP_NAME"
    fi
    
    mkdir "$APP_NAME"

    mkdir "$APP_NAME/Contents"
    mkdir "$APP_NAME/Contents/MacOS"
    mkdir "$APP_NAME/Contents/Resources"

    cp "$INFO_PLIST" "$APP_NAME/Contents/Info.plist"
    cp "$ICON_FILE" "$APP_NAME/Contents/Resources/icon.icns"
    cp -a "$PUBLISH_OUTPUT_DIRECTORY" "$APP_NAME/Contents/MacOS"
done


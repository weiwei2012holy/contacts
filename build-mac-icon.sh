#!/bin/bash

array=(16 32 64 128 256 512)

icon=Assets/app-icon.png

dirName="Assets/icons.iconset"
mkdir ${dirName}
for size in ${array[*]}
do
  sips -z ${size} ${size} ${icon} -o ${dirName}/icon_${size}x${size}.png
  sips -z ${size}*2 ${size}*2 ${icon} -o ${dirName}/icon_${size}x${size}@2x.png
done

iconutil -c icns ${dirName} -o Assets/icon.icns

rm -rf ${dirName}
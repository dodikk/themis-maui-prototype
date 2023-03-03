
lipo -create \
-output themis_fat.so \
./themis.xcframework/ios-arm64/themis.framework/themis \
./themis.xcframework/ios-arm64_x86_64-simulator/themis.framework/themis 


### Macos disabled due to
# fatal error: 
# /Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/lipo: 
# ./themis.xcframework/ios-arm64/themis.framework/themis and 
# ./themis.xcframework/ios-arm64_x86_64-simulator/themis.framework/themis 
# have the same architectures (arm64) and can't be in the same fat output 
# file
#################

#\
#./themis.xcframework/macos-arm64_x86_64/themis.framework/Versions/A/themis 



#### Still getting this error though
# fatal error: 
# /Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/lipo: 
# ./themis.xcframework/ios-arm64/themis.framework/themis and 
# ./themis.xcframework/ios-arm64_x86_64-simulator/themis.framework/themis 
# have the same architectures (arm64) and can't be in the same fat output 
# file

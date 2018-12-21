#!/bin/bash

currentFolder=${PWD}
pathToApp=$currentFolder/FastlaneSnapshotXamarin/FastlaneSnapshotXamarin/bin/iPhoneSimulator/Debug/device-builds/*/FastlaneSnapshotXamarin.app

deviceIds=(
    "0E96EC68-2BAF-4617-BFC3-80143BAB173A" # iPhone 8
    # "12A03C06-3657-493A-9904-10B30816E397" # iPhone 8 plus
    # "0C48BF5A-B51B-42DF-9768-C92693161D43" # iPhone X
    # "273ED77A-1311-4CCE-8226-0B361AB211F5" # iPhone 5s
) 

deploy() {
    echo booting simulator $1
    xcrun simctl boot $1

    echo deploying app
    xcrun simctl install $1 $pathToApp

    echo shutdown simulator
    xcrun simctl shutdown $1
}

for i in "${deviceIds[@]}"
do
    deploy $i
done
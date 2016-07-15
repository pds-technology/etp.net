#!/bin/bash

cd etp
GIT_HASH=`git rev-parse --short HEAD`
GIT_BRANCH=$(git branch | sed -n -e 's/^\* \(.*\)/\1/p')
cd ..
echo $GIT_HASH
echo $GIT_BRANCH
sed -E 's/__GITHASH__/'"$GIT_HASH"'/' Properties/AssemblyInfo.template.cs | sed -E 's/__BUILD__/'"$1"'/' > Properties/AssemblyInfo.cs

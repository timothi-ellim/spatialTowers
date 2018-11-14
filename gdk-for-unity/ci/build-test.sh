#!/usr/bin/env bash

set -e -u -o -x pipefail

cd "$(dirname "$0")/../"

# Get shared CI and prepare unity
ci/bootstrap.sh
.shared-ci/scripts/prepare-unity.sh
.shared-ci/scripts/prepare-unity-mobile.sh "$(pwd)/logs/PrepareUnityMobile.log"

source ".shared-ci/scripts/pinned-tools.sh"

ci/test.sh
.shared-ci/scripts/build.sh "workers/unity" UnityClient local "$(pwd)/logs/UnityClientBuild.log"
.shared-ci/scripts/build.sh "workers/unity" UnityGameLogic cloud "$(pwd)/logs/UnityGameLogicBuild.log"
.shared-ci/scripts/build.sh "workers/unity" AndroidClient local "$(pwd)/logs/AndroidClientBuild.log"

if isMacOS; then
  .shared-ci/scripts/build.sh "workers/unity" iOSClient local "$(pwd)/logs/iOSClientBuild.log"
fi

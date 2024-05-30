#!/usr/bin/env bash

mkdir integration-test
cd integration-test

wget https://repo.jellyfin.org/files/server/portable/latest-stable/any/jellyfin_10.9.3.zip
unzip jellyfin_*.zip -d .

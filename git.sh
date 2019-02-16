#!/bin/sh

echo "Write File Name"
read file
git init
git add $file
git commit -m "update"
git push origin packages

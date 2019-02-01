#!/bin/sh

  echo "Write commi message"
  read message
  git init
  git add .
  git commit -m "update$message"
  git push origin master

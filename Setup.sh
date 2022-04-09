#!/bin/bash

dotnet run --project ./C#Programs/"Console App".csproj &&
kill -9 $PPID


@ECHO off
CLS
SETLOCAL EnableDelayedExpansion

REM Store the current directory
SET currPath=%CD%

REM Get a valid rootPath from the user
ECHO Enter the fully qualified path to a root directory 
ECHO that contains subdirectories with MCD files.
ECHO OFB files will be generated for all subdirectories.
SET /p rootPath=">"
IF NOT EXIST "!rootPath!" (
	ECHO Directory not found
	PAUSE & EXIT
)

REM Get a valid destination path from the user
ECHO.
ECHO Enter the fully qualified name of a template OFB file
ECHO on which the generated OFB files will be based.
ECHO This file will have Dir statements automatically generated.
SET /p templateFile=">"
IF NOT EXIST "!templateFile!" (
	ECHO File not found
	PAUSE & EXIT
)

REM Get a valid destination path from the user
ECHO.
ECHO Finally, enter the fully qualified path to a directory
ECHO where you wish to place the generated OFB files.
ECHO All .ofb files in this directory will be overwritten or removed.
SET /p destPath=">"
IF NOT EXIST "!destPath!" (
	ECHO Directory not found
	PAUSE & EXIT
)

REM Delete all the old .ofb files in the destination directory
DEL "!destPath!\*.ofb"

REM Move to the provided path (may be on a different drive)
CHDIR /D "!rootPath!"

REM For each subdirectory in the rootPath
SET count=1
ECHO.
FOR /d /r %%D IN (*) DO (
	REM If this subdirectory contains at least one .mcd file...
	IF EXIST "%%~fD\*.mcd" (	
		REM Create an .ofb file named like "count_subDirectoryName.ofb"		
		REM Add the line that queues all .mcd files in the rootPath directory
		> "!destPath!\!count!_%%~nD.ofb" (
			ECHO // Queue all .MCD files in the directory
			ECHO Dir %%~fD\*.mcd
			ECHO(
		)
		
		REM Append lines from the template .ofb file
		TYPE "!templateFile!" >> "!destPath!\!count!_%%~nD.ofb"
		
		REM Increase the file count and show the fileName just processed on the console
		ECHO Created !count!_%%~nD.ofb
		SET /a count+=1
	)
)

ECHO.
ECHO All OFB files are now in the directory "!destPath!"

PAUSE
ENDLOCAL
@ECHO on

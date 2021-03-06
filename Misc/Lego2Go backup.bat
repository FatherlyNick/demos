:: # Bat used to compress a folder and then copy it into a cloud client; A backup of sorts. This script will ask for# ::
:: # user input while it runs. A version file needs to exist. Its used to keep track of the current version.        # ::
:: #  Every time script runs, the version file is incremented by 1		                                    # ::
:: # To customise this, edit the vars highlighted with ###


::no need to echo everything
@echo off

::Set the title of cmd.exe
title Lego2Go.dx.am backup in progress!

::clear the screen
cls

:: ### User Home dir ###
set HOME=C:\Users\Niko.K\Desktop

:: ### User OneDrive dir ###
set OD=C:\Users\Niko.K\OneDrive\Documents\l2g

::switch to the right directory no matter where the batch is started
cd %HOME%

::reformat the date variable to be able to save it as a file name
set date1=%date:~0,2%.%date:~3,2%.%date:~8,2%

::Get the latest version number from the version file ###
set /p versionNum=< C:\l2g-ver.txt

::increment the version number
set /a versionNum=%versionNum%+1

::Save this new number to the version file
echo %versionNum% > C:\l2g-ver.txt

::Application name
set appName=lego2go.dx.am

::Set the final backup name
set fileName=%appName%.%date1%-%versionNum%.7z

::Let user check if everything is correct
echo The project of version %versionNum% will be backed up into an archive called %fileName%
set /p bool=Is this correct? y/n...

if %bool% EQU y (
	"C:\Program Files\7-Zip\7z.exe" a "%HOME%\%fileName%" lego2go.dx.am
	echo *** Operation complete ***
			
	pause
) else (

	echo *** Operation cancelled by user ***

	pause
)
set /p bool_=Would you like to copy %filename% to OneDrive? y/n...
if %bool_% EQU y (
		copy %fileName% %OD%

		echo *** Copy complete ***
		pause
	) else (
	echo *** Copy cancelled by user ***

)
set /p bool__=Would you like to delete the archive %filename% ? y/n...
if %bool__% EQU y (
		del %filename%
		echo *** Deletion complete ***
		pause
	
	) else (

	echo *** Operation cancelled by user ***
	pause
)
	

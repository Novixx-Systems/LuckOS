if "%1" == "" goto end
@echo off
makecab %1
set _YES=%1
copy %_YES:~0,-1%_ M:\NVXLKOS\DATA\I386
del %_YES:~0,-1%_
:end
Skeleton which provides a prepared "empty" mod usable for any Unity Game 

Instructions:

1. Download and unzip the latest release of this repo
2. Open the Solution file (*.sln) with Visual Studio
3. Adjust the project and assembly name in the project settings
4. Adjust the paths to the Stranded Deep / UMM Assembly's under "References"
5. Adjust the steam path variable in the postbuild event script
6. Start coding your mod

As an alternative, you can create a new project yourself and just copy the "Info.json", "Main.cs" and "Settings.cs" into it. Then you don't have to adjust the assembly paths. If you also copy the postbuild event script, you have to copy the file "CreateZIP.bat" to the root directory of your project as well.

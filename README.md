----------- Unturned Server Manager -----------


# Requirements:

[.Net Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48) or later versions


# Changelog:

**V4.0.1.2** -
* Rocketmod shut their dedicated machines down. "Latest" rocketmod version is now permanently [#1363](https://github.com/RocketMod/Rocket.Unturned/releases/tag/4.9.3.0)
* Modified update menu to work correctly without rocketmod versions.

**V4.0.1.1** -
* Updated .NET Framework to 4.8
* Updated packages to latest versions

**V4.0.1.0** -
* Added Try Catch to prevent crashing when retrieving RocketMod's latest build if it isn't available.
* Added a message when downloading rocketmod fails.
* Added support to run SteamCMD on Linux without checking if it exists (See Linux install wiki)
* Added support to startup a server on Linux by using ServerHelper.sh that comes with 1110390.
* Added minor console logging for startup/shutdown of a server since 1110390 doesn't have fully functional console output in Linux.
* Added install check support for Linux (verifying that Unturned_Headless.x86_64 exists).
* Added a limit to how many times verification of the installation happens (Previously unlimited, now only 10 tries).
* Updated packages to latest versions.
* Changed APPID download from 304930 (Unturned) to 1110390 (Unturned Dedicated Server Tool)
* Changed initial message to not mention 10GB required, and instead mention 3GB minimum. (U3DS is small in comparison to the base game)
* Changed all links from my previous username to my current username.
* Removed Steam Login (1110390 can be downloaded with Anonymous steam login) 
* Removed tracking of unturned version, instead using DateTime to figure out when was the last update done at.
* Removed unneeded Memory.Servers and moved its use to Loading.Servers.
* Removed all in-software icons (current incompatibility with Linux)
* Fixed server cloning not copying over the settings.
* Fixed changing settings not applying to the server.
* Fixed unable to create servers with a space in their name.
* Fixed any possible errors during download from crashing the program.
* Fixed all paths to use a normal slash instead of a backwards slash (Compatibility with Linux)
* Fixed GameConfiguration.cs for JSON (Was using fields, now uses properties)

**V4.0.0.2** - 
* Removed vanilla server option due to high disk usage.
* Fixed updating menu crashing the application.
* Code Cleanup (Jetbrains Rider)

**V4.0.0.1** -
* Fixed raised exception when leaving the map field empty in the server configuration, saving and loading it again. (Credit to Luke_ArOres#0769 for finding it)
* Fixed forgotten addition of auto-detection of workshop maps. (Credit to Luke_ArOres#0769 for reminding of this issue)
* Fixed minor issue when loading maps for a vanilla server.
* Updated Fody and Costura.Fody to latest versions.

**V4.0.0.0** -

* Added more local control over server instances.
* Added filesystem control.
* Added constants file.
* Added steam login.
* Added Costura.Fody so that no referenced libraries are required next to the executable
* Improved plugin installer.
* Improved workshop installer.
* Improved design for the manager.
* Improved installation checking.
* Improved the entry for clean loading.
* Improved back-end downloading + Updating.
* Improved form controls for the server settings.
* Improved saved configuration files to json formatted files.
* Changed version retreival from github file to custom build numbers.
* Changed background colour to "Control" from FF0000.
* Removed project signing (due to Costura.Fody issues).
* Removed self-version checking.
* Removed logging.
* Fixed updating issues.
* Cleaned up & organised code.

**V3.0.1.4** - 

* Fixed A Problem With The Updater Tool GUI Displaying + Storing The Wrong Version Values.

**V3.0.1.3** - 

* Fixed The Ability To Launch More Than 1 Instance Of USM.
* Fixed TickTimer Form Showing When Doing Alt+Tab.

**V3.0.1.2** - 

* Fixed A Problem With Plugin Integrity Update.

**V3.0.1.1** - 

* Fixed The Ability To Resize The Updater Tool.
* Fixed The Startup Position Of The Server Settings Tool And Updater Tool.
* Re-Added USMVer.dat File To Notify Old Versions Of New Update.

**V3.0.1.0** - 

* Fixed The Inability To Change The Server Path From GUI.
* Fixed Inability To Start Program Again After Force Shutdown/Crash.
* Fixed Plugin Lists And Download.
* Fixed Unturned Version Not Updating On GUI With "Update All".
* Fixed Unknown DLL Files When Installing Some Plugins.
* Fixed Way To Download Data Files.
* Fixed The Bug With Using A Link In The Install By ID.
* Changed Unturned Updater Redirector.
* Added Versions.zip And Plugins.zip To Data Folder.
* Added .GitIgnore To Upload The Code Easier Without The Loss Of Local Data.
* Removed USM.exe, PIVer.dat, Plugins.dat, PluginsDl.dat, PluginsPage.dat, RocVer.dat, UntVer.dat And USMVer.dat From Data Folder.

**V3.0.0.5** - 

* Fixed Multiple Bugs With The Workshop Install Tool.
* Fixed Logger.
* Fixed Unturned Install.
* Fixed "Update All" Workshop Items Bug.
* Fixed Install By Id Workshop Items Bug.
* Changed Unturned Install Method.

**V3.0.0.4** - 

* Fixed Unable To Start Program In Offline Mode
* Fixed Bug When Puting A Non-Directory Link In Workshop Installer.
* Fixed Multiple Bugs With The Unturned Updater.
* Removed Comment About Unturned Updating Being Disabled.
* Enabled/Added Unturned Update Option.
* Added Option To Install Workshop Items By Item ID.
* Added "Update All" Button To Workshop Installer.
* Added Logger & System Logging To Log.txt.
* Changed Background Color To All Forms.

**V3.0.0.3** - 

* Fixed Updater.
* Fixed Few Errors With Plugin Installer.
* Fixed Few Errors With Downloader.cs.
* Fixed Per-Server Saving Issue.
* Fixed Issue With Plugin Management Button Being Active After Server Launch.
* Fixed Issue With Not Setting Difficulty.
* Changed Server ID Managing.
* Removed Github File Rocket_Latest.zip - Changed To Rocket Direct Download Link.

**V3.0.0.2** - 

* Fixed An Error With The Versions.dat File.

**V3.0.0.1** - 

* Fixed An Error When Launching The Updater Tool.
* Fixed A Bug Returning An Exception When Loading The Plugin Installer Without The PI Files.
* Added A Loop To Check If Rocket Is Installed, If It Isn't Plugin Install Is Disabled.

**V3.0.0.0** - 

* Fixed Issue With Gold Mode.
* Fixed Rocket Installation Freezing.
* Fixed Rocket Updating.
* Fixed/Added Ease of install for plugins.
* Fixed Bug With Workshop Item IDs Not Displaying.
* Fixed Per-Server SRS.
* Added Full Updater.
* Added Plugin Integrity files to include downloads and web pages to working plugins and their names.
* Added System Tray Icon.
* Added Local Server Configuration Files.
* Added Button To Open Selected Workshop Items In Browser.
* Disabled Unturned Updating For A Future, Much Better Update.
* Removed Rocket Updating Animation.
* Removed Global SRS.
* Removed Rocket Libraries.
* Changed User Interface.
* Changed Max servers from 4 to 100.
* Changed USM.lock file position.
* Changed Per-Server SRS Limiters.
* Changed Self-Version Checking Feature To The Full Updater + Notification.
* Changed USM Configuration File.


**V2.0.0.0** 

* Added Link To Reddit Post.
* Fixed SRS (Shutdown, Restart and Start) Buttons To Apply To The Servers That The Program Started Only.
* Added Rocket Install, Workshop Install And Plugin Install (Plugin install is buggy!).
* Added Per-Server SRS Features.

**V2.0.1.0**
* Update README 
   
----------- Unturned Server Manager -----------

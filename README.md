# PDMUtility

This project is a Windows application that enables users to change the archive server PDM instance they are connected to.

## Requirements

- .NET Framework 4.8
- C# 10.0
- Tested using Solidworks PDM Professional 2023 SP3

## Build

The project is built as a Windows executable (WinExe) targeting x64 platforms.

## Dependencies

The project has the following NuGet package dependencies:

- Costura.Fody 5.7.0
- MaterialSkin.2 2.3.1
- Newtonsoft.Json 13.0.3

## Configuration

The project uses a `config.json` file for configuration. This file is copied to the output directory when the project is built. 
An example configuration file (`config.json.example`) is included.  The '.example' extension should be removed from the file name and the file should be updated with the correct values.

## Usage
Populate the config.json file with archive server names, locations, and vaults available on each server. 
Build the project and run the executable.  Both the executable and config file should be saved in the same directory.

The application will display a list of available archive servers sorted by ping time.
Select the desired target server and desired vault.  Then hit the 'Update Archive Server' button to update the archive server.

The application will update the below registry key with the new archive server name:
```HKEY_LOCAL_MACHINE\SOFTWARE\SolidWorks\Applications\PDMWorks Enterprise\Databases\<VaultName>\ServerLoc```

Status messages will be displayed in the application window.  If the update is sucessful, restart PDM for the changes to take effect.

## Icon

The application uses the `EPDMDraftSight.ico` icon.

## Version

The current assembly version is 1.0.0.0.

## License
GPL-3.0-or-later

## Author
[Jamey Evans](https://github.com/JameyEvans)



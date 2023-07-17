; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Booker"
#define MyAppVerName "Booker 1.5.1.0"
#define MyAppPublisher "Angarato Surion"
#define MyAppExeName "Booker.exe"

[Setup]
AppName={#MyAppName}
AppVerName={#MyAppVerName}
AppPublisher={#MyAppPublisher}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
LicenseFile=Y:\�� ������� ���\Attribution-Noncommercial-No Derivative Works 3.txt
OutputDir=.\Output\
AppPublisherURL=http://pariskoutsioukis.net/
AppSupportURL=http://pariskoutsioukis.net/
AppUpdatesURL=http://pariskoutsioukis.net/
OutputBaseFilename={#MyAppVerName}-setup_with_Plugins
Compression=lzma/ultra64
SolidCompression=true
InternalCompressLevel=ultra64

[Languages]
Name: eng; MessagesFile: compiler:Default.isl

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked
Name: quicklaunchicon; Description: {cm:CreateQuickLaunchIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked

[Files]
Source: "..\..\..\..\My Programs\dotNet\Booker\Booker\bin\Release\Booker.exe"; DestDir: "{app}"; Flags: ignoreversion
;Source: Y:\My Programs\dotNet\Booker\Booker\bin\Release\HydroBugger.dll; DestDir: {app}; Flags: ignoreversion
Source: "..\..\..\..\My Programs\Scrabler Scripts\Installer.scrf"; DestDir: "{app}\ScriptRunner"; DestName: "autostart.scrf"
Source: "..\..\..\..\My Programs\dotNet\Booker\Booker\bin\Release\dbinfo.hbt"; DestDir: "{app}"
Source: "..\..\..\..\My Programs\dotNet\Booker\Booker\bin\Release\*.hbt"; DestDir: "{app}"
Source: "..\..\..\..\My Programs\dotNet\ScriptRunner\ScriptRunner\bin\Release\*"; DestDir: "{app}\ScriptRunner"
Source: "..\..\..\..\My Programs\dotNet\Booker\Booker\bin\Release\config\*"; DestDir: "{app}\ScriptRunner\config"
Source: "..\..\..\..\My Programs\dotNet\HydroPlugins\Feedback Sender\Feedback Sender\bin\Release\Feedback Sender.dll"; DestDir: "{app}"
Source: "..\..\..\..\My Programs\dotNet\HydroPlugins\Feedback Sender\Feedback Sender\bin\Release\Feedback Sender.pdb"; DestDir: "{app}"
Source: "..\..\..\..\My Programs\dotNet\Booker\Booker\bin\Release\*"; DestDir: "{app}"; Flags: ignoreversion createallsubdirs recursesubdirs; Excludes: "*.log ErrorLogs"

[Icons]
Name: {group}\{#MyAppName}; Filename: {app}\{#MyAppExeName}
Name: {group}\{cm:UninstallProgram,{#MyAppName}}; Filename: {uninstallexe}
Name: {userdesktop}\{#MyAppName}; Filename: {app}\{#MyAppExeName}; Tasks: desktopicon
Name: {userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}; Filename: {app}\{#MyAppExeName}; Tasks: quicklaunchicon
Name: {group}\Booker Application Folder; Filename: {app}\
Name: {userdesktop}\Booker Application Folder; Filename: {app}\
Name: {group}\Configuration Application; Filename: {app}\ScriptRunner\ScriptRunner.exe; Parameters: -as; Tasks: ; Languages: ; WorkingDir: {app}\ScriptRunner
Name: {group}\Hydrobase Advanced Config; Filename: {app}\Hydrobase Advanced Config.exe; WorkingDir: {app}

[Run]
Filename: {app}\{#MyAppExeName}; Description: {cm:LaunchProgram,{#MyAppName}}; Flags: postinstall skipifsilent
Filename: {app}\ScriptRunner\ScriptRunner.exe; Flags: nowait; Parameters: -as; WorkingDir: {app}\ScriptRunner

[UninstallDelete]
Name: {app}; Type: filesandordirs; Tasks: ; Languages: 
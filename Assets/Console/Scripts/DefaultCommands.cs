using UnityEngine;
using UnityEngine.UI;

public class DefaultCommands : MonoBehaviour
{
    static string booltostring(bool a)
    {
        return a ? "1" : "0";
    }

    public static void  regcom()
    {
        ConsoleCommandsDatabase.RegisterCommand(    Settings.sensitivityname,               Settings.sensitivitydescription,               Settings.sensitivitycon,               Settings.sensitivity.ToString()               );
        ConsoleCommandsDatabase.RegisterCommand(    Settings.sv_gravityname,                Settings.sv_gravitydescription,                Settings.sv_gravitycon,                Settings.sv_gravity.ToString()                );
        ConsoleCommandsDatabase.RegisterCommand(    Settings.sv_frictionname,               Settings.sv_frictiondescription,               Settings.sv_frictioncon,               Settings.sv_friction.ToString()               );
        ConsoleCommandsDatabase.RegisterCommand(    Settings.sv_movespeedname,              Settings.sv_movespeeddescription,              Settings.sv_movespeedcon,              Settings.sv_movespeed.ToString()              );
        ConsoleCommandsDatabase.RegisterCommand(    Settings.sv_noclipspeedname,            Settings.sv_noclipspeeddescription,            Settings.sv_noclipspeedcon,            Settings.sv_noclipspeed.ToString()            );
        ConsoleCommandsDatabase.RegisterCommand(    Settings.sv_runaccelerationname,        Settings.sv_runaccelerationdescription,        Settings.sv_runaccelerationcon,        Settings.sv_runacceleration.ToString()        );
        ConsoleCommandsDatabase.RegisterCommand(    Settings.sv_rundeccelerationname,       Settings.sv_rundeccelerationdescription,       Settings.sv_rundeccelerationcon,       Settings.sv_rundecceleration.ToString()       );
        ConsoleCommandsDatabase.RegisterCommand(    Settings.sv_airaccelerationname,        Settings.sv_airaccelerationdescription,        Settings.sv_airaccelerationcon,        Settings.sv_airacceleration.ToString()        );
        ConsoleCommandsDatabase.RegisterCommand(    Settings.sv_airdeccelerationname,       Settings.sv_airdeccelerationdescription,       Settings.sv_airdeccelerationcon,       Settings.sv_airdecceleration.ToString()       );
        ConsoleCommandsDatabase.RegisterCommand(    Settings.sv_aircontrolname,             Settings.sv_aircontroldescription,             Settings.sv_aircontrolcon,             Settings.sv_aircontrol.ToString()             );
        ConsoleCommandsDatabase.RegisterCommand(    Settings.sv_sidestrafeaccelerationname, Settings.sv_sidestrafeaccelerationdescription, Settings.sv_sidestrafeaccelerationcon, Settings.sv_sidestrafeacceleration.ToString() );
        ConsoleCommandsDatabase.RegisterCommand(    Settings.sv_sidestrafespeedname,        Settings.sv_sidestrafespeeddescription,        Settings.sv_sidestrafespeedcon,        Settings.sv_sidestrafespeed.ToString()        );
        ConsoleCommandsDatabase.RegisterCommand(    Settings.sv_jumpspeedname,              Settings.sv_jumpspeeddescription,              Settings.sv_jumpspeedcon,              Settings.sv_jumpspeed.ToString()              );
        ConsoleCommandsDatabase.RegisterCommand(    Settings.sv_cheatsname,                 Settings.sv_cheatsdescription,                 Settings.sv_cheatscon,                 Settings.sv_cheats                            );
        ConsoleCommandsDatabase.RegisterCommand(    Settings.noclipname,                    Settings.noclipdescription,                    Settings.noclipcon,                    Settings.noclip                               );
        ConsoleCommandsDatabase.RegisterCommand(    Settings.savename,                      Settings.savedescription,                      Settings.savecon                                                                     );
        ConsoleCommandsDatabase.RegisterCommand(    Settings.execname,                      Settings.execdescription,                      Settings.execcon                                                                     );
        ConsoleCommandsDatabase.RegisterCommand(    QuitCommand.name,                       QuitCommand.description,                       QuitCommand.con                                                                      );
        ConsoleCommandsDatabase.RegisterCommand(    HelpCommand.name,                       HelpCommand.description,                       HelpCommand.con                                                                      );
        ConsoleCommandsDatabase.RegisterCommand(    LoadCommand.name,                       LoadCommand.description,                       LoadCommand.con                                                                      );
    }    
}
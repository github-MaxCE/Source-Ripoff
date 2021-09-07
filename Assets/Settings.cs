using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class Settings : MonoBehaviour
{
    public static float sensitivity = 80.0f;
    public static readonly string sensitivityname = "sensitivity";
    public static readonly string sensitivitydescription = "change mouse sensitivity";

    public static float sv_gravity = 20.0f;
    public static readonly string sv_gravityname = "sv_gravity";
    public static readonly string sv_gravitydescription = "SERVER: the gravity applied to the player";

    public static float sv_friction = 6f; //Ground friction
    public static readonly string sv_frictionname = "sv_friction";
    public static readonly string sv_frictiondescription = "SERVER: the friction experienced when running on the ground";

    public static float sv_movespeed = 7.0f;                // Ground move speed
    public static readonly string sv_movespeedname = "sv_movespeed";
    public static readonly string sv_movespeeddescription = "SERVER: the max speed you can achieve when running";

    public static float sv_runacceleration = 14.0f;         // Ground accel
    public static readonly string sv_runaccelerationname = "sv_runacceleration";
    public static readonly string sv_runaccelerationdescription = "SERVER: the acceleration of running";

    public static float sv_rundecceleration = 10.0f;       // Deacceleration that occurs when running on the ground
    public static readonly string sv_rundeccelerationname = "sv_rundecceleration";
    public static readonly string sv_rundeccelerationdescription = "SERVER: the decceleration experienced when ground running";

    public static float sv_airacceleration = 2.0f;          // Air accel
    public static readonly string sv_airaccelerationname = "sv_airacceleration";
    public static readonly string sv_airaccelerationdescription = "SERVER: the accleration of air strafing";

    public static float sv_airdecceleration = 2.0f;         // Deacceleration experienced when ooposite strafing
    public static readonly string sv_airdeccelerationname = "sv_airdecceleration";
    public static readonly string sv_airdeccelerationdescription = "SERVER: the decceleration experienced when air strafing";

    public static float sv_aircontrol = 0.3f;               // How precise air control is
    public static readonly string sv_aircontrolname = "sv_aircontrol";
    public static readonly string sv_aircontroldescription = "SERVER: change the precision of air strafing";

    public static float sv_sidestrafeacceleration = 50.0f;  // How fast acceleration occurs to get up to sideStrafeSpeed when
    public static readonly string sv_sidestrafeaccelerationname = "sv_sidestrafeacceleration";
    public static readonly string sv_sidestrafeaccelerationdescription = "SERVER: change the acceleration value of side strafing";

    public static float sv_sidestrafespeed = 1.0f;          // What the max speed to generate when side strafing
    public static readonly string sv_sidestrafespeedname = "sv_sidestrafespeed";
    public static readonly string sv_sidestrafespeeddescription = "SERVER: change the speed to generate when strafing";

    public static float sv_jumpspeed = 8.0f;                // The speed at which the character's up axis gains when hitting jump
    public static readonly string sv_jumpspeedname = "sv_jumpspeed";
    public static readonly string sv_jumpspeeddescription = "SERVER: change the speed at which the character reaches the max jump distance";


    public static bool sv_cheats = false;                        // enables cheats
    public static readonly string sv_cheatsname = "sv_cheats";
    public static readonly string sv_cheatsdescription = "SERVER: enables commands that you wouldn't be able to change (disables achievements)";

    public static readonly string savename = "save";
    public static readonly string savedescription = "CLIENT: saves all user modified values";


    public static readonly string execname = "exec";
    public static readonly string execdescription = "executes commands written in a .cfg file";


    public static readonly string echoname = "echo";
    public static readonly string echodescription = "prints string to console";


    public static bool noclip = false;
    public static readonly string noclipname = "noclip";
    public static readonly string noclipdescription = "lets you fly through walls";


    public static float sv_noclipspeed = 0.1f;
    public static readonly string sv_noclipspeedname = "sv_noclipspeed";
    public static readonly string sv_noclipspeeddescription = "speed of nocliping";


    //template
    //public static readonly string name = "";
    //public static readonly string description = "";

    static public string m_Path;

    static string[] lines = null;

    public  InputField inputField;

    public Camera m_Camera;

    public InputActionAsset inputActionAsset;

    private static int booltoint(bool a)
    {
    return a ? 1 : 0;
    }
    private static bool inttobool(int a) {
    return a == 1;
    }

    public void Sensitivity()
    {
        sensitivity = float.Parse(inputField.text/*, CultureInfo.InvariantCulture.NumberFormat*/);
        refreshfield();
    }


    public void refreshfield()
    {
        var defaultText = $"{Settings.sensitivity.ToString()}";
        inputField.text = defaultText;
    }

    private void Start()
    {
        Load();
    }

    public static void Save()
    {
        Settings settings = GameObject.Find("GameObject").GetComponent<Settings>();

        foreach (var actionMap in settings.inputActionAsset.actionMaps)
        {
            foreach (var binding in actionMap.bindings)
            {
                if (!string.IsNullOrEmpty(binding.overridePath))
                {
                    string key = binding.id.ToString();
                    string val = binding.overridePath;
                    PlayerPrefs.SetString(key, val);
                }
            }
        }


        PlayerPrefs.SetInt(     "resw"                          , settings.m_Camera.pixelWidth               );
        PlayerPrefs.SetInt(     "resh"                          , settings.m_Camera.pixelHeight              );
        PlayerPrefs.SetInt(     "resf"                          , booltoint(Screen.fullScreen)               );
        PlayerPrefs.SetInt(     "quality"                       , QualitySettings.GetQualityLevel()          );
        PlayerPrefs.SetFloat(   "sensitivity"                   , sensitivity                                );
        PlayerPrefs.SetFloat(   "sv_gravity"                    , sv_gravity                                 );
        PlayerPrefs.SetFloat(   "sv_friction"                   , sv_friction                                );
        PlayerPrefs.SetFloat(   "sv_movespeed"                  , sv_movespeed                               );
        PlayerPrefs.SetFloat(   "sv_runacceleration"            , sv_runacceleration                         );
        PlayerPrefs.SetFloat(   "sv_rundecceleration"           , sv_rundecceleration                        );
        PlayerPrefs.SetFloat(   "sv_airacceleration"            , sv_airacceleration                         );
        PlayerPrefs.SetFloat(   "sv_airdecceleration"           , sv_airdecceleration                        );
        PlayerPrefs.SetFloat(   "sv_aircontrol"                 , sv_aircontrol                              );
        PlayerPrefs.SetFloat(   "sv_sidestrafeacceleration"     , sv_sidestrafeacceleration                  );
        PlayerPrefs.SetFloat(   "sv_sidestrafespeed"            , sv_sidestrafespeed                         );
        PlayerPrefs.SetFloat(   "sv_jumpspeed"                  , sv_jumpspeed                               );
        PlayerPrefs.SetInt(     "ranbefore"                     , 1                                          );


        PlayerPrefs.Save();
    }

    public static void Load()
    {
        Settings settings = GameObject.Find("GameObject").GetComponent<Settings>();

        foreach (var actionMap in settings.inputActionAsset.actionMaps)
        {
            var bindings = actionMap.bindings;
            for (int i = 0; i < bindings.Count; i++)
            {
                var binding = bindings[i];
                string key = binding.id.ToString();
                string val = PlayerPrefs.GetString(key, null);
                if (string.IsNullOrEmpty(val)) continue;
                actionMap.ApplyBindingOverride(i, new InputBinding {overridePath = val });
            }
        }

        if(PlayerPrefs.HasKey("resf") == true)
        {
            Screen.SetResolution(PlayerPrefs.GetInt("resw"), PlayerPrefs.GetInt("resh"), inttobool(PlayerPrefs.GetInt("resf")));
        }

        if(PlayerPrefs.HasKey("quality"))
        {
            QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("quality"));
        }

        sensitivity                 = PlayerPrefs.GetFloat(   "sensitivity"                  );
        sv_gravity                  = PlayerPrefs.GetFloat(   "sv_gravity"                   );
        sv_friction                 = PlayerPrefs.GetFloat(   "sv_friction"                  );
        sv_movespeed                = PlayerPrefs.GetFloat(   "sv_movespeed"                 );
        sv_runacceleration          = PlayerPrefs.GetFloat(   "sv_runacceleration"           );
        sv_runacceleration          = PlayerPrefs.GetFloat(   "sv_rundecceleration"          );
        sv_airacceleration          = PlayerPrefs.GetFloat(   "sv_airacceleration"           );
        sv_airdecceleration         = PlayerPrefs.GetFloat(   "sv_airdecceleration"          );
        sv_aircontrol               = PlayerPrefs.GetFloat(   "sv_aircontrol"                );
        sv_sidestrafeacceleration   = PlayerPrefs.GetFloat(   "sv_sidestrafeacceleration"    );
        sv_sidestrafespeed          = PlayerPrefs.GetFloat(   "sv_sidestrafespeed"           );
        sv_jumpspeed                = PlayerPrefs.GetFloat(   "sv_jumpspeed"                 );


        settings.refreshfield();
    }

    public static string noclipcon(params string[] args)
    {
        if(sv_cheats)
        {
            noclip = !noclip;
            return string.Format("{0} is {1}", noclipname, (noclip? "ON" : "OFF"));
        }
        else
            return "cheats are disabled";
    }

    public static string echocon(params string[] args)
    {
        return string.Join(" ", args).Replace("\\\"", "@longstrqtnjhnfjnlkhgrite^").Replace("\"", "").Replace("@longstrqtnjhnfjnlkhgrite^", "\"");
    }

    public static string execcon(params string[] args)
    {
        if(args.Length == 0)
        {
            return HelpCommand.con(execname);
        }
        else
        {    
            if (File.Exists(m_Path + "/" + args[0]))
            {
                lines = File.ReadAllLines(m_Path + "/" + args[0]);
                foreach(var x in lines)
                {
                    execute.ExecuteCommand(x, true);
                }
                return null;
            }
            else
                return args[0] + " does not exist at:\n" + "       " + m_Path;
        }
    }
    public static string savecon(params string[] args)
    {
        Save();
        return null;
    }

    public static string sv_cheatscon(params string[] args)
    {
        if(args.Length == 0)
            return HelpCommand.con(sv_cheatsname);  
        else
            if(Regex.IsMatch(args[0], @"^\d+$"))
            {
                sv_cheats = inttobool(int.Parse(args[0]));
                return string.Format("{0} is {1}", sv_cheatsname, (sv_cheats? "ON" : "OFF" ));
            }
            return "\"" + args + "\" is not a number, retry with 0 or 1";
    }

    public static string sensitivitycon(params string[] args)
    {
        if(args.Length == 0)
            return HelpCommand.con(sensitivityname);
        else
            sensitivity = float.Parse(args[0], CultureInfo.InvariantCulture.NumberFormat);
            return string.Format("{0} = \"{1}\"", sensitivityname, sensitivity);
    }

    public static string sv_gravitycon(params string[] args)
    {
        if(args.Length == 0)
            return HelpCommand.con(sv_gravityname);
        else
            if(sv_cheats)
            {
                if(Regex.IsMatch(args[0], @"^\d+$"))
                {
                    sv_gravity = float.Parse(args[0], CultureInfo.InvariantCulture.NumberFormat);
                    return string.Format("{0} = \"{1}\"", sv_gravityname, sv_gravity);
                }
                else
                    return HelpCommand.con(sv_gravityname);
            }
            else
                return "cheats are disabled";
    }

    public static string sv_frictioncon(params string[] args)
    {
        if(args.Length == 0)
            return HelpCommand.con(sv_frictionname);
        else
            if(sv_cheats)
            {
                if(Regex.IsMatch(args[0], @"^\d+$"))
                {
                    sv_friction = float.Parse(args[0], CultureInfo.InvariantCulture.NumberFormat);
                    return string.Format("{0} = \"{1}\"", sv_frictionname, sv_friction);
                }
                else
                    return HelpCommand.con(sv_frictionname);
            }
            else
                return "cheats are disabled";
    }

    public static string sv_noclipspeedcon(params string[] args)
    {
        if(args.Length == 0)
            return HelpCommand.con(sv_noclipspeedname);
        else
            if(sv_cheats)
            {
                if(Regex.IsMatch(args[0], @"^\d+$"))
                {
                    sv_noclipspeed = float.Parse(args[0], CultureInfo.InvariantCulture.NumberFormat);
                    return string.Format("{0} = \"{1}\"", sv_noclipspeedname, sv_noclipspeed);
                }
                else
                    return HelpCommand.con(sv_noclipspeedname);
            }
            else
                return "cheats are disabled";
    }

    public static string sv_movespeedcon(params string[] args)
    {
        if(args.Length == 0)
            return HelpCommand.con(sv_movespeedname);
        else
            if(sv_cheats)
            {
                if(Regex.IsMatch(args[0], @"^\d+$"))
                {
                    sv_movespeed = float.Parse(args[0], CultureInfo.InvariantCulture.NumberFormat);
                    return string.Format("{0} = \"{1}\"", sv_movespeedname, sv_movespeed);
                }
                else
                    return HelpCommand.con(sv_movespeedname);
            }
            else
                return "cheats are disabled";
    }

    public static string sv_runaccelerationcon(params string[] args)
    {
        if(args.Length == 0)
            return HelpCommand.con(sv_runaccelerationname);
        else
            if(sv_cheats)
            {
                if(Regex.IsMatch(args[0], @"^\d+$"))
                {
                    sv_runacceleration = float.Parse(args[0], CultureInfo.InvariantCulture.NumberFormat);
                    return string.Format("{0} = \"{1}\"", sv_runaccelerationname, sv_runacceleration);
                }
                else
                    return HelpCommand.con(sv_movespeedname);

            }
            else
                return "cheats are disabled";
    }

    public static string sv_rundeccelerationcon(params string[] args)
    {
        if(args.Length == 0)
            return HelpCommand.con(sv_rundeccelerationname);
        else
            if(sv_cheats)
            {
                if(Regex.IsMatch(args[0], @"^\d+$"))
                {
                    sv_rundecceleration = float.Parse(args[0], CultureInfo.InvariantCulture.NumberFormat);
                    return string.Format("{0} = \"{1}\"", sv_rundeccelerationname, sv_rundecceleration);
                }
                else
                    return HelpCommand.con(sv_rundeccelerationname);
            }
            else
                return "cheats are disabled";
    }

    public static string sv_airaccelerationcon(params string[] args)
    {
        if(args.Length == 0)
            return HelpCommand.con(sv_airaccelerationname);
        else
            if(sv_cheats)
            {
                if(Regex.IsMatch(args[0], @"^\d+$"))
                {
                    sv_airacceleration = float.Parse(args[0], CultureInfo.InvariantCulture.NumberFormat);
                    return string.Format("{0} = \"{1}\"", sv_airaccelerationname, sv_airacceleration);
                }
                else
                    return HelpCommand.con(sv_airaccelerationname);
            }
            else
                return "cheats are disabled";
    }

    public static string sv_airdeccelerationcon(params string[] args)
    {
        if(args.Length == 0)
            return HelpCommand.con(sv_airdeccelerationname);
        else
            if(sv_cheats)
            {
                if(Regex.IsMatch(args[0], @"^\d+$"))
                {
                    sv_airdecceleration = float.Parse(args[0], CultureInfo.InvariantCulture.NumberFormat);
                    return string.Format("{0} = \"{1}\"", sv_airdeccelerationname, sv_airdecceleration);
                }
                else
                    return HelpCommand.con(sv_airdeccelerationname);
            }
            else
                return "cheats are disabled";
    }

    public static string sv_aircontrolcon(params string[] args)
    {
        if(args.Length == 0)
            return HelpCommand.con(sv_aircontrolname);
        else
            if(sv_cheats)
            {
                if(Regex.IsMatch(args[0], @"^\d+$"))
                {
                    sv_aircontrol = float.Parse(args[0], CultureInfo.InvariantCulture.NumberFormat);
                    return string.Format("{0} = \"{1}\"", sv_aircontrolname, sv_aircontrol);
                }
                else
                    return HelpCommand.con(sv_aircontrolname);
            }
            else
                return "cheats are disabled";
    }

    public static string sv_sidestrafeaccelerationcon(params string[] args)
    {
        if(args.Length == 0)
            return HelpCommand.con(sv_sidestrafeaccelerationname);
        else
            if(sv_cheats)
            {
                if(Regex.IsMatch(args[0], @"^\d+$"))
                {
                    sv_sidestrafeacceleration = float.Parse(args[0], CultureInfo.InvariantCulture.NumberFormat);
                    return string.Format("{0} = \"{1}\"", sv_sidestrafeaccelerationname, sv_sidestrafeacceleration);
                }
                else
                    return HelpCommand.con(sv_sidestrafeaccelerationname);
            }
            else
                return "cheats are disabled";
    }

    public static string sv_sidestrafespeedcon(params string[] args)
    {
        if(args.Length == 0)
            return HelpCommand.con(sv_sidestrafespeedname);
        else
            if(sv_cheats)
            {
                if(Regex.IsMatch(args[0], @"^\d+$"))
                {
                    sv_sidestrafespeed = float.Parse(args[0], CultureInfo.InvariantCulture.NumberFormat);
                    return string.Format("{0} = \"{1}\"", sv_sidestrafespeedname, sv_sidestrafespeed);
                }
                else
                    return HelpCommand.con(sv_sidestrafespeedname);
            }
            else
                return "cheats are disabled";
    }

    public static string sv_jumpspeedcon(params string[] args)
    {
        if(args.Length == 0)
            return HelpCommand.con(sv_jumpspeedname);
        else
            if(sv_cheats)
            {
                if(Regex.IsMatch(args[0], @"^\d+$"))
                {
                    sv_jumpspeed = float.Parse(args[0], CultureInfo.InvariantCulture.NumberFormat);
                    return string.Format("{0} = \"{1}\"", sv_jumpspeedname, sv_jumpspeed);
                }
                else
                    return HelpCommand.con(sv_jumpspeedname);
            }
            else
                return "cheats are disabled";
    }
}
using UnityEngine;
using System.Collections;

public class Constants {
	public static string SPLASH_SCENE 	= "Splash";
	public static string TITLE_SCENE 	= "Title";
	public static string LOCATION_SCENE = "Location";

	public static int SPLASH_TIME = 2; // in seconds

	public static string LOCATIONS      = "Data/locations";
	public static string USERDATA_FILE  = "user.dat";

	public static int ON_DATA_UNLOADED = -1;
	public static int ON_DATA_LOADED = 0;

	public static int ON_USERDATA_UNSAVED = -2;
	public static int ON_USERDATA_NOT_INITIALIZED = -1;
	public static int ON_USERDATA_LOADED = 0;
	public static int ON_USERDATA_SAVED = 1;
	public static int ON_USERDATA_INITIALIZED = 2;

	public static int LEVEL_SPLASH = 0;
	public static int LEVEL_TITLE = 1;
	public static int LEVEL_LOCATION = 2;

	public static int BTN_CLOSE_OPTIONS_POPUP = -1;
	public static int BTN_OPTIONS = 0;
	public static int BTN_ENERGY = 3;
	public static int BTN_TOKENS = 2;
	public static int BTN_MONEY = 1;

}

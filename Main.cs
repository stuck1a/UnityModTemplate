using UnityEngine;
using UnityModManagerNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HarmonyLib;

namespace StrandedDeepLongplayMod {

  static class Main {

    public static bool Enabled;
    public static UnityModManager.ModEntry.ModLogger Logger;
    public static Settings Settings;


    /*
     * Called once when loading the mod.
     * Mainly used to link all hook functions and validate succesful loading of the mod.
     */
    public static bool Load(UnityModManager.ModEntry modEntry) {
      Settings = Settings.Load<Settings>(modEntry);
      Logger = modEntry.Logger;

      modEntry.OnGUI = OnGUI;
      modEntry.OnSaveGUI = OnSaveGUI;
      modEntry.OnUpdate = OnUpdate;
      modEntry.OnToggle = OnToggle;

      #if DEBUG
        Logger.Log("\""+ modEntry.Info.DisplayName + "\" loaded.");
      #endif

      return true;
    }


    /*
     * Called whenever the user enables/disables the mod in the UnityModManager GUI.
     */
    static bool OnToggle(UnityModManager.ModEntry modEntry, bool value) {
      try {
        Enabled = value;
      } catch (Exception e) {
        #if DEBUG
          Logger.LogException(e);
        #endif
        Enabled = !Enabled;
        return false;
      }

      return true;
    }


    /*
     * Called every time the UnityModManager GUI is opened (with CTRL+F10, or at start).
     * Mainly used to render and update mod settings.
     */
    static void OnGUI(UnityModManager.ModEntry modEntry) {
      Settings.MyBooleanSetting = GUILayout.Toggle(Settings.MyBooleanSetting, Settings.Label_MyBooleanSetting);
      Settings.AnotherBooleanSetting = GUILayout.Toggle(Settings.AnotherBooleanSetting, Settings.Label_AnotherBooleanSetting);
    }


    /*
     * Called when the user clicks the "Save" button in the UnityModManager GUI.
     */
    static void OnSaveGUI(UnityModManager.ModEntry modEntry) {
      Settings.Save(modEntry);
    }


    /*
     * Called at every game frame, so add your custom mod logic here.
     * Note that this function is called very frequently, so avoid unnecessary heavy calculations
     * to minimize the performance impact from your mod.
     */
    static void OnUpdate(UnityModManager.ModEntry modEntry, float dt) {
      // Do nothing is the mod is disabled
      if (!Enabled) {
        return;
      }

      // Do something here
      // ...

    }

  }
}

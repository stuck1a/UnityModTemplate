using UnityModManagerNet;

namespace StrandedDeepLongplayMod {

  public class Settings: UnityModManager.ModSettings {

    /* Declaration of all mod settings and default values */
    public bool MyBooleanSetting = true;
    public bool AnotherBooleanSetting = true;

    /* Labels for each mod setting */
    public string Label_MyBooleanSetting = "I am a setting label";
    public string Label_AnotherBooleanSetting = "I am another setting label";


    /*
     * Stores all settings in "Settings.xml" through UnityModManager.
     */
    public override void Save(UnityModManager.ModEntry modEntry) {
      Save<Settings>(this, modEntry);
    }

  }
}

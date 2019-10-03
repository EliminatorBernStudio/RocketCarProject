using UnityEditor;
using UnityEngine;

public class ResetSetting : MonoBehaviour
{
    [MenuItem ("Edit/Reset Preferences")]
	public static void ResetPrefs() {
		if(EditorUtility.DisplayDialog("Reset editor preferences?", "Reset all editor preferences? This cannot be undone.", "Yes", "No")) {
			EditorPrefs.DeleteAll();
		}
	}
}

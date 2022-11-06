# ConfigLoader
ConfigLoader is a class that will load the config.json file from the URL

## Images
<img src="https://raw.githubusercontent.com/devloli-main/ConfigLoader/main/Images/ConfigLoader.png" width="500px"</img>

## Usage Example
```cs
using UnityEditor;
using UnityEngine;

namespace Renegade
{
    public class ShowOutput : EditorWindow
    {
        [MenuItem("Renegade/Show Output")]
        public static void ShowWindow()
        {
            GetWindow(typeof(ShowOutput));
        }

        private void OnGUI()
        {
            titleContent = new GUIContent("Renegade X SDK");
            ConfigLoader configLoader = new ConfigLoader();

            GUILayout.BeginVertical("box");
            GUILayout.Label("Config Data", EditorStyles.boldLabel);
            GUILayout.Label($"Name: {configLoader.Name}");
            GUILayout.Label($"Age: {configLoader.Age}");
            GUILayout.Label($"Pronouns: {string.Join(", ", configLoader.Pronouns)}");
            GUILayout.Label($"Country: {configLoader.Country}");
            GUILayout.Label($"Languages: {string.Join(", ", configLoader.Languages)}");
            GUILayout.Label($"Hobbies: {string.Join(", ", configLoader.Hobbies)}");
            GUILayout.Label($"Status: {configLoader.Status}");
            GUILayout.Label($"Ask Me About: {string.Join(", ", configLoader.AskMeAbout)}");
            GUILayout.Label($"Current Focus: {configLoader.CurrentFocus}");
            GUILayout.Label($"Email: {configLoader.Email}");
            GUILayout.Label($"Discord: {configLoader.Discord}");
            GUILayout.EndVertical();

            minSize = new Vector2(455, 240);
            maxSize = minSize;
        }
    }
}
```

## License
[MIT](https://choosealicense.com/licenses/mit/)

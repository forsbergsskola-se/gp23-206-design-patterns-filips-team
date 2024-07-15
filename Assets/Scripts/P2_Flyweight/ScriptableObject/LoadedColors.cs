using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LoadedColors", menuName = "ScriptableObjects/LoadedColors", order = 1)]
public class LoadedColors : ScriptableObject
{
    public string fileContents;

    public void LoadFromResources(string jsonFileName)
    {
        // Use jsonFileName variable to load the correct JSON file from Resources folder
        TextAsset textAsset = Resources.Load<TextAsset>(jsonFileName);
        if (textAsset != null)
        {
            fileContents = textAsset.text;
            Debug.Log("Data loaded from JSON to ScriptableObject");
        }
        else
        {
            Debug.LogError("Failed to load JSON file: " + jsonFileName);
        }
    }
}
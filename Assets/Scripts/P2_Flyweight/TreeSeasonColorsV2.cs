using UnityEngine;
using UnityEditor;
using System.IO;

public class LoadColorData
{
    [MenuItem("Tools/Load Tree Color Data")]
    public static void LoadData()
    {
        var fileContents = Resources.Load<TextAsset>("treeColors").text;
        var colors = JsonUtility.FromJson<ColorInfoWrapper>(fileContents);

        var asset = ScriptableObject.CreateInstance<TreeSeasonColorsData>();
        asset.colors = colors.colors;

        AssetDatabase.CreateAsset(asset, "Assets/Resources/TreeSeasonColorsData.asset");
        AssetDatabase.SaveAssets();
    }

    [System.Serializable]
    private class ColorInfoWrapper
    {
        public ColorInfo[] colors;
    }
}
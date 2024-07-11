using UnityEngine;

[CreateAssetMenu(fileName = "TreeSeasonColorsData", menuName = "ScriptableObjects/TreeSeasonColorsData", order = 1)]
public class TreeSeasonColorsData : ScriptableObject
{
    public ColorInfo[] colors;

    public Color GetColor(int index)
    {
        var colorInfo = colors[index % colors.Length];
        return new Color(colorInfo.r, colorInfo.g, colorInfo.b, 1f);
    }
}

[System.Serializable]
public struct ColorInfo
{
    public float r, g, b;
}
using UnityEngine;

public class TreeV2 : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    public TreeSeasonColorsData treeColorsData;
    private int _currentIndex;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();

        // Load color data into ScriptableObject if it's not already assigned
        if (treeColorsData == null)
        {
            LoadColorData.LoadData(); // Call the static method to load data from JSON
            treeColorsData = Resources.Load<TreeSeasonColorsData>("TreeSeasonColorsData");
        }

        UpdateSeason();
    }

    void FixedUpdate()
    {
        UpdateSeason();
    }

    void UpdateSeason()
    {
        if (treeColorsData == null || treeColorsData.colors == null || treeColorsData.colors.Length == 0)
        {
            Debug.LogError("TreeV2: TreeSeasonColorsData is not properly initialized.");
            return;
        }

        _currentIndex++;
        _spriteRenderer.color = treeColorsData.GetColor(_currentIndex);
    }
}
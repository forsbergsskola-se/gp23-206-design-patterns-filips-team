using System;
using UnityEngine;

public class Tree : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private TreeSeasonColors _treeColors;
    [SerializeField]  private LoadedColors loadedColors;
    private int _tick;
    public string jsonFileName = "treeColors";
   
    void Start()
    {
        this._spriteRenderer = GetComponent<SpriteRenderer>();
      //  LoadColorInfos();
      if (loadedColors.fileContents ==null)
      {
          loadedColors.LoadFromResources(jsonFileName);
      }

      _treeColors = JsonUtility.FromJson<TreeSeasonColors>(loadedColors.fileContents);
        UpdateSeason();
        
    }
    void FixedUpdate()
    {
        UpdateSeason();
    }
    /// <summary>
    /// In the Tree Colors, the Artist assigned very specific values for the seasoning tree.
    /// Each tree needs to access their colors depending on how old they are.
    /// Unfortunately, this solution uses up a lot of Memory :(
    /// </summary>
   /*
    void LoadColorInfos()
    {   
       // var fileContents = Resources.Load<TextAsset>("treeColors").text;
       this._treeColors = JsonUtility.FromJson<TreeSeasonColors>(loadedColors.fileContents);

        Debug.Log("Data loaded from JSON from ScriptableObject"); 
    }
    */
    void UpdateSeason()
    {
        this._treeColors.MoveNext();
        this._spriteRenderer.color = this._treeColors.CurrentColor;
    }
}


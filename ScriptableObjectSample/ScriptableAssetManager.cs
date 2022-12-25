using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableAssetManager : MonoBehaviour
{
    [SerializeField]
    private PlayerFileDBAsset playerFileDBAsset;

    private void GetPlayerInfo()
    {
        for (int i = 0; i < playerFileDBAsset.playerFileAssets.Count; i++)
        {
            print($"{playerFileDBAsset.playerFileAssets[i].name}/{playerFileDBAsset.playerFileAssets[i].attack}" +
                $"/{playerFileDBAsset.playerFileAssets[i].defense}/{playerFileDBAsset.playerFileAssets[i].sprite}");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            GetPlayerInfo();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "playerFileDB", menuName = "playerFileDB")]
public class PlayerFileDBAsset : ScriptableObject
{
    public List<PlayerFileAsset> playerFileAssets;
}

[System.Serializable]
public class PlayerFileAsset
{
    public string name;
    public float attack;
    public float defense;
    public Sprite sprite;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="CardEntity", menuName = "create card entity")]
public class CardEntity : ScriptableObject
{
    public int number;
    public Sprite icon;
}

using UnityEngine;

[CreateAssetMenu(fileName = "Chunk", menuName = "Scriptable Objects/Chunk")]
public class Chunk : ScriptableObject
{
    [SerializeField]
    public GameObject Prefab1,Prefab2,Prefab3;
    
}

using UnityEngine;


[CreateAssetMenu(fileName = "PrefabListData", menuName = "ScriptableObjects/PrefabListData", order = 1)]
public class PrefabListData : ScriptableObject
{
    [SerializeField] private Object[] prefabs;
    public Object[] Prefabs { get => prefabs; private set => prefabs = value; }

}

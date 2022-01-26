using UnityEngine;

public class Chunk : MonoBehaviour
{
    [SerializeField] private Transform begin;
    [SerializeField] private Transform end;

    public Transform End { get => end; private set => end = value; }
    public Transform Begin { get => begin; private set => begin = value; }

    bool IsNull(Object obj, string log = "")
    {
        if (obj == null)
        {
            Debug.LogError("Not Init or Null Error!" + log);
            return true;
        }
        else return false;
    }


    private void Start()
    {
        IsNull(Begin, "стартовая точка не установленна ");
        IsNull(End);
    }

}

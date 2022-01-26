using UnityEngine;
using UnityEngine.Events;

public class StateStickman : MonoBehaviour
{
    [SerializeField] private Material currentMaterial;

    public UnityEvent applyStateEvent;
    
    private MeshRenderer meshRenderer;
    
    public Material CurrentMaterial => currentMaterial;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<SetterStateStickman>())
        {
            currentMaterial = other.gameObject.GetComponent<SetterStateStickman>().CurrentMaterial;
            ApplyState();
        }
    }

    public void ApplyState()
    {
        if (currentMaterial != null)
            meshRenderer.material = currentMaterial;
        applyStateEvent?.Invoke();
    }

    private void Awake()
    {
        meshRenderer = GetComponentInChildren<MeshRenderer>();
        ApplyState();
    }
}

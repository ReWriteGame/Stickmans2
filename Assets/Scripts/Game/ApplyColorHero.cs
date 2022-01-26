using UnityEngine;

public class ApplyColorHero : MonoBehaviour
{
   [SerializeField] private StateStickman stateStickman;
   [SerializeField] private SkinnedMeshRenderer[] skinnedMeshRenderer;

   private void OnEnable()
   {
      stateStickman.applyStateEvent.AddListener(SetColor);
   }

   private void OnDisable()
   {
      stateStickman.applyStateEvent.RemoveListener(SetColor);
   }

   private void SetColor()
   {
      foreach (SkinnedMeshRenderer mesh in skinnedMeshRenderer)
         mesh.material = stateStickman.CurrentMaterial;
   }
}

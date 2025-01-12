using UnityEngine;

namespace Scripts.Utilities.Editor.MaterialSetterSystem
{
    public class MaterialSetter : MonoBehaviour
    {
        [SerializeField] private Material _material;

        [ContextMenu("Set Material")]
        private void SetMaterial()
        {
            MeshRenderer[] meshRenderers = gameObject.GetComponentsInChildren<MeshRenderer>();
            SkinnedMeshRenderer[] skinnedMeshRenderers = gameObject.GetComponentsInChildren<SkinnedMeshRenderer>();

            foreach (MeshRenderer renderer in meshRenderers)
                renderer.sharedMaterial = _material;

            foreach (SkinnedMeshRenderer renderer in skinnedMeshRenderers)
                renderer.sharedMaterial = _material;
        }
    }
}
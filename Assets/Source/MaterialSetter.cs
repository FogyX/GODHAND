using UnityEngine;
using UnityEngine.Serialization;

namespace Source
{
    public class MaterialSetter : MonoBehaviour
    {
        [SerializeField] private Material _bodyMaterial;
        [SerializeField] private Material _hairMaterial;
        
        [ContextMenu("Set Material")]
        private void SetMaterial()
        {
            Renderer[] renderers = gameObject.GetComponentsInChildren<Renderer>();

            foreach (Renderer meshRenderer in renderers)
            {
                Material usedMaterial = meshRenderer.gameObject.name.ToLower().Contains("hair") ? 
                    _hairMaterial : _bodyMaterial;
                
                Material[] materials = meshRenderer.sharedMaterials;

                for (int i = 0; i < materials.Length; i++)
                    materials[i] = usedMaterial;

                meshRenderer.sharedMaterials = materials;
            }
        }
    }
}
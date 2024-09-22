using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class SkyboxChanger : MonoBehaviour
{
    [SerializeField] private List<AssetReference> skyboxMaterials;

    private int _currentIndex = 0;
    private void ChangeSkybox()
    {
        skyboxMaterials[_currentIndex].LoadAssetAsync<Material>().Completed += handle =>
        {
            RenderSettings.skybox = handle.Result;
            _currentIndex++;

            if (_currentIndex > skyboxMaterials.Count - 1)
                _currentIndex = 0;
        };
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
            ChangeSkybox();
    }
}

using UnityEngine;

public class EmployeeSpawnable : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    
    public EmployeeGeneratedPreset Preset;
    
    public void SetUp(Transform spawnPoint, EmployeeGeneratedPreset employeeGeneratedPreset)
    {
        transform.SetParent(spawnPoint);
        transform.position = spawnPoint.position;
        spriteRenderer.sprite = employeeGeneratedPreset.Sprite;
        Preset = employeeGeneratedPreset;
    }
}
using UnityEngine;

public class EmployeeSpawnable : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    
    private EmployeeGeneratedPreset _preset;
    
    public void SetUp(Transform spawnPoint, EmployeeGeneratedPreset employeeGeneratedPreset)
    {
        transform.SetParent(spawnPoint);
        transform.position = spawnPoint.position;
        spriteRenderer.sprite = employeeGeneratedPreset.Sprite;
    }
}
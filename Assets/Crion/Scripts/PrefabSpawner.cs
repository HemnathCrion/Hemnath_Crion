using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabSpawner : MonoBehaviour
{
    public Dropdown prefabDropdown;
    public List<GameObject> prefablist;
    public Button spawnButton;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void SpawnSelectedPrefab()
    {
        int index = prefabDropdown.value;
        if (index < 0  )
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Cube_Controller : MonoBehaviour
{
    public GameObject cube;
    public Slider slider;
    public InputField nameInput;
    public TMP_Text nameText;
    public Button nameChange;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = cube.transform.localScale.x;

        slider.onValueChanged.AddListener(UpdateCubeSize);

        nameChange.onClick.AddListener(changeCubeName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateCubeSize(float newSize)
    {
        cube.transform.localScale = new Vector3(newSize, newSize, newSize);
    }

    void changeCubeName()
    {
        string newName = nameInput.text;

        if (!string.IsNullOrEmpty(newName) )
        {
            cube.name = newName;
            nameText.text = "" + newName;
        }
    }
}

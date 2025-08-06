using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buttons_scripts : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject button;
    public GameObject threeD; // Renamed variable to a valid identifier
    public Text statues;
    public void ShowTutorial()
    {
        tutorial.SetActive(true);
        threeD.SetActive(false);
        statues.text = "You push on button tutorial";
        button.SetActive(true);
    }

    public void Show3D()
    {
        tutorial.SetActive(false);
        threeD.SetActive(true);
        statues.text = "You push on button 3D";
        button.SetActive(false);

    }
}

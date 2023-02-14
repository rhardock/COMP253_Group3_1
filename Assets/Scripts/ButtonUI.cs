using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUI : MonoBehaviour
{
    [SerializeField] private GameObject image1;
    [SerializeField] private GameObject image2;
    [SerializeField] private GameObject image3;

    int currentVisible = 0;

    // Start is called before the first frame update
    public void NewGameButton()
    {
        currentVisible++;
        if (currentVisible > 3)
            currentVisible= 0;

        image1.SetActive(false);
        image2.SetActive(false);
        image3.SetActive(false);

        switch (currentVisible)
        {
            case 0: image1.SetActive(true);
                break;

            case 1: image2.SetActive(true);
                break;

            case 2: image3.SetActive(true);
                break;

            default:
                break;

        }

        // Debug.Log("Button Pressed");
    }

    public void ExitGameButton()
    {
        // Debug.Log("Button Pressed");
        Application.Quit();
    }
}

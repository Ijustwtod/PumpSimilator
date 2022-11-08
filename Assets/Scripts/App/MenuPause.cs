using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPause : MonoBehaviour
{
    public GameObject menuPaused;
    public GameObject crosshair;
    private GameObject _camera;
    private bool isMenuPaused = false;

    private void Start()
    {
        menuPaused.SetActive(false);
    }
    private void Update()
    {
        ActiveMenu();
    }
    void ActiveMenu() 
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            isMenuPaused = !isMenuPaused;
            if (isMenuPaused) 
            {
                menuPaused.SetActive(true);
                crosshair.SetActive(false);
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0f;
                Camera.main.GetComponent<CustomCamera>().mouseSensitivity = 0;
            }
            else 
            {
                menuPaused.SetActive(false);
                crosshair.SetActive(true);
                Cursor.lockState = CursorLockMode.Locked;
                Time.timeScale = 1f;
                Camera.main.GetComponent<CustomCamera>().mouseSensitivity = 3;
            }
        }
    }
}

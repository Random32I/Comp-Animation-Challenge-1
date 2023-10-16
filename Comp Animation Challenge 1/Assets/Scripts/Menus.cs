using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menus : MonoBehaviour
{
    [SerializeField] GameObject UI;
    [SerializeField] GameObject Menu;
    [SerializeField] GameObject Items;
    bool isPaused;
    bool menuOpen;
    bool itemsOpen;
    [SerializeField] Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Equals) && !itemsOpen)
        {
            isPaused = !isPaused;
            UI.SetActive(!UI.activeSelf);
            Menu.SetActive(!Menu.activeSelf);
            menuOpen = !menuOpen;
        }
        else if (Input.GetKeyDown(KeyCode.B) && !menuOpen)
        {
            isPaused = !isPaused;
            UI.SetActive(!UI.activeSelf);
            Items.SetActive(true);
            itemsOpen = !itemsOpen;
            if (!itemsOpen)
            {
                animator.SetBool("IsPaused", false);
                if (animator.IsInTransition(0))
                {
                    Items.SetActive(false);
                }
            }
            else
            {
                animator.SetBool("IsPaused", true);
            }
        }
    }
}

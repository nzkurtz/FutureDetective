using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destoryeverythignbsript : MonoBehaviour
{
    private void Start()
    {
        Destroy(Dontdestroynotebook.notebook.gameObject);
        Destroy(GameManager.gameManager.gameObject);
        Destroy(HotbarUI.hotbar.gameObject);
    }
}

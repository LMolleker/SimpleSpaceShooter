using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Retry : MonoBehaviour
{
    public GameObject player;
    public Button btn;
    // Start is called before the first frame update
    void Start()
    {
        btn.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(player == null)
        {
            btn.gameObject.SetActive(true);
        }
    }

    public void retry()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

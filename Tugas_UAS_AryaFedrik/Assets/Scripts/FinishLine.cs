using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public int itemValue = 1;
    public GameObject Player;
    private static int core;

    // Update is called once per frame
    void Update()
    {
        float Distance = Vector3.Distance(gameObject.transform.position, Player.transform.position);
        float maxDistance = 1f;
        bool isNear = Distance <= maxDistance;


        if(Input.GetKeyUp(KeyCode.F) && isNear)
        {
            core = Score.score;
            if(core >= 4)
            {
                SceneManager.LoadScene("Paramadina");
            }
            else
            {
                Debug.Log("Ambil Lagi!");
            }
        }

    }
}

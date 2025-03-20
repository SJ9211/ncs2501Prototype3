using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private float speed;
    private Rigidbody playerRb;
    private float horizontalInput;
    private float verticalInput;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerRb.AddForce(Vector3.forward * 20f , ForceMode.Impulse);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            playerRb.AddForce(Vector3.back * 20f, ForceMode.Impulse);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerRb.AddForce(Vector3.left * 20f, ForceMode.Impulse);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerRb.AddForce(Vector3.right * 20f, ForceMode.Impulse);
        }
    }

    /*
    // 중복되는 코드를 짜놓은후 같은곳에 이 코드를 넣어주면 깔끔해짐
    private void MovePlayer(Vector3 val)
    {
        playerRb.AddForce(val * 20f, ForceMode.Impulse);
    }
    */
}

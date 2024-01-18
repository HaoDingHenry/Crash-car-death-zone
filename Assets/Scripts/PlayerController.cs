using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private float speed = 25.0f;
    private float turnSpeed = 80.0f;
    private float horizontalInput;
    private float forwardInput;
    public GameObject car; // 小车的引用
    public Text gameOverText; // UI文本的引用



    //25.0f for floating-point number (single precision)

    // Start is called before the first frame update
    void Start()
    {
        gameOverText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Input.GetAxis("Horizontal")：It will return a value.


        //Move the vihicle forward.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        //Vector3.up：Vector3.up（0,1,0）；Vector3.forward：Vector3.up（0,0,1）
        //Time.deltaTime：Keep moving objects moving at the same average speed at the same time

        if (car != null && !car.activeSelf)
        {
            GameOver();
        }
    }
    void GameOver()
    {
        // 显示游戏结束文本
        gameOverText.gameObject.SetActive(true);
        // 在这里可以添加其他游戏结束的逻辑，例如暂停游戏、播放音效等
        Time.timeScale = 0f; // 暂停游戏
    }
    public void RestartGame()
    {
        // 恢复游戏时间
        Time.timeScale = 1f;

        // 重新加载当前场景
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}


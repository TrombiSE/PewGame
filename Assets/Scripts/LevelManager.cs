﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    public Transform respawnPoint;
    public GameObject playerPrefab;

    public CinemachineVirtualCameraBase cam;

    private void Awake()
    {
        instance = this;
    }

    public void Respawn()
    {
        
        GameObject player = Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);

        cam.Follow = player.transform;
    }
    private void Update()
    {
        if (Input.GetKey("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class Health : NetworkBehaviour
{
    public bool destroyOnDeath;
    public const int maxHealth = 100;
    public RectTransform healBar;

    [SyncVar(hook = "OnChangeHealth")]
    public int currentHeal = maxHealth;

    NetworkStartPosition[] spawnPoints;
    
    void Start()
    {
        if (isLocalPlayer) {
            spawnPoints = FindObjectsOfType<NetworkStartPosition>();
        }
    }
    public void TakeDamage(int amount)
    {
        if (!isServer)
            return;

        currentHeal -= amount;

        if (currentHeal <= 0)
        {
            if (destroyOnDeath)
            {
                Destroy(gameObject);
            }
            else
            {
                currentHeal = maxHealth;
                RpcRespawn();
            }
        }
    }

    void OnChangeHealth(int currentHealth)
    {
        healBar.sizeDelta = new Vector2(currentHeal, healBar.sizeDelta.y);
    }

    [ClientRpc]
    void RpcRespawn()
    {
        if (isLocalPlayer)
        {
            Vector3 spawnPoint = Vector3.zero;

            if (spawnPoints != null && spawnPoints.Length > 0) {
                spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position;
            }

            transform.position = spawnPoint;
        }
    }
}

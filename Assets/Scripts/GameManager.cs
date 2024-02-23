using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ebac.Core.Singleton;
using DG.Tweening;
public class GameManager : Singleton<GameManager>
{
    [Header("Player")]
    public GameObject playerPrefab;

    [Header("Enemies")]
    public List<GameObject> enemies;

    [Header("References")]
    public Transform starPointPlayer;

    [Header("Animation")]
    public float duration = .2f;
    public float delay = .05f;
    public Ease ease = Ease.OutBack;  //ajuste de animação

    private GameObject _currentPlayer;

    public void Start()
    {
        Init();
    }

    public void Init()
    {
        SpawnPlayer();
    }

    private void SpawnPlayer() 
    {
        _currentPlayer = Instantiate(playerPrefab);
        _currentPlayer.transform.position = starPointPlayer.transform.position;
        _currentPlayer.transform.DOScale(0, duration).SetEase(ease).From().SetDelay(delay);
    }
}

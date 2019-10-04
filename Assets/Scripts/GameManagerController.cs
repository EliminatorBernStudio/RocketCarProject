using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerController : MonoBehaviour
{
    public GameObject Car;
    public GameObject PlayerInput;
    public int CountPlayers;
    public Transform CarSpawn1;
    public Transform CarSpawn2;

    public const string PLAYER_1_UP = "PLAYER_1_UP";
    public const string PLAYER_1_LEFT = "PLAYER_1_LEFT";
    public const string PLAYER_1_RIGHT = "PLAYER_1_RIGHT";
    public const string PLAYER_1_DOWN = "PLAYER_1_DOWN";
    public const string PLAYER_2_UP = "PLAYER_2_UP";
    public const string PLAYER_2_LEFT = "PLAYER_2_LEFT";
    public const string PLAYER_2_RIGHT = "PLAYER_2_RIGHT";
    public const string PLAYER_2_DOWN = "PLAYER_2_DOWN";

    
     // Start is called before the first frame update
    void Start()
    {
        //TODO check for maxPlayers
        for (int i = 0; i < CountPlayers; i++) {
            var playerInput = Instantiate(PlayerInput);
            PlayerInputController playerInputController = playerInput.GetComponent<PlayerInputController>();
            if (i == 0) {
                playerInputController.Forward = PLAYER_1_UP;
                playerInputController.Left = PLAYER_1_LEFT;
                playerInputController.Right = PLAYER_1_RIGHT;
                playerInputController.Down = PLAYER_1_DOWN;
                var car = Instantiate(Car, CarSpawn1);
                playerInputController.Car = car;
            }
            if (i == 1) {
                playerInputController.Forward = PLAYER_2_UP;
                playerInputController.Left = PLAYER_2_LEFT;
                playerInputController.Right = PLAYER_2_RIGHT;
                playerInputController.Down = PLAYER_2_DOWN;
                var car = Instantiate(Car, CarSpawn2);
                playerInputController.Car = car;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

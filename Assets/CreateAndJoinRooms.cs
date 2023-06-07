using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public TMP_InputField  createInput;

    public TMP_InputField  joinInput;

    public void CreateRoom()
    {
       PhotonNetwork.JoinRoom(joinInput.text);
       Debug.Log("create rooom");
    }

    public void JoinRoom(){
        PhotonNetwork.JoinRoom(joinInput.text);
        Debug.Log("joinRoom called");
    }
    
    public override void OnJoinedRoom(){
        PhotonNetwork.LoadLevel("Game");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

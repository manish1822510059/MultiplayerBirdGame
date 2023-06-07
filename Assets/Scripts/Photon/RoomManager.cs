using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class RoomManager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(" Connecting ...............");
        PhotonNetwork.ConnectUsingSettings();
    }

  public override void OnConnectedToMaster(){
    base.OnConnectedToMaster();
    Debug.Log("Connected to server");
    PhotonNetwork.JoinLobby();
  } 

  public override void OnJoinedLobby(){
    base.OnJoinedLobby();
    PhotonNetwork.JoinOrCreateRoom(roomName:"test",roomOptions:null,typedLobby:null);
    Debug.Log("We're Connected and in a room");

  }


}

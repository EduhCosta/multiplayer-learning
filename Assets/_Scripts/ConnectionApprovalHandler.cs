using Unity.Netcode;
using UnityEngine;

public class ConnectionApprovalHandler : MonoBehaviour
{
    private const int MaxPlayers = 1;

    void Start()
    {
        NetworkManager.Singleton.ConnectionApprovalCallback = ApprovalCheck;        
    }

    private void ApprovalCheck(NetworkManager.ConnectionApprovalRequest req, NetworkManager.ConnectionApprovalResponse res)
    {
        res.Approved = true;
        res.CreatePlayerObject = true;
        res.PlayerPrefabHash = null;

        if (NetworkManager.Singleton.ConnectedClients.Count > MaxPlayers)
        {
            res.Approved = false;
            res.Reason = "Server is Full";
        }

        res.Pending = false;
    }
}

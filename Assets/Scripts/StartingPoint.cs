using UnityEngine;

public class StartingPoint:MonoBehaviour {
    [SerializeField] private GameObject playerPrefab;

    internal void LaunchPlayer() {
        GameObject _playerPrefab = Instantiate(playerPrefab,transform.position,transform.rotation);

        Player _player = _playerPrefab.GetComponent<Player>();

        if (_player != null) {
            _player.Gyro.SetGyro(true);
        }
    }

}

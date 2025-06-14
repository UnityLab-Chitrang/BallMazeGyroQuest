using UnityEngine;

[RequireComponent(typeof(GyroControl))]
public class Player:MonoBehaviour {
    private GyroControl _gyro;
    internal GyroControl Gyro {
        get {
            if (_gyro == null) {
                _gyro = GetComponent<GyroControl>();
            }
            return _gyro;
        }
    }
}

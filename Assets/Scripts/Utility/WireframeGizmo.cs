using UnityEngine;

[ExecuteInEditMode]
public class WireframeGizmo:MonoBehaviour {
    public Mesh mesh;
    public Color wireColor = Color.green;

#if UNITY_EDITOR
    private void OnDrawGizmos() {
        if (mesh == null)
            return;

        Gizmos.color = wireColor;

        // Draw the mesh in wireframe mode
        Gizmos.DrawWireMesh(mesh,transform.position,transform.rotation,transform.localScale);
    }
#endif
}

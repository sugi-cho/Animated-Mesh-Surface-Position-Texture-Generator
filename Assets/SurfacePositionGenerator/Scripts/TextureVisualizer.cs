using UnityEngine;

public class TextureVisualizer : MonoBehaviour {
    SurfaceTextureGenerator texGen;


	// Use this for initialization
	void Start () {
        texGen = GetComponent<SurfaceTextureGenerator>();
	}
	
	// Update is called once per frame
	void Update () {
        texGen.UpdateRts();
	}

    private void OnGUI()
    {
        var w = Screen.width * 0.5f;
        var h = Screen.height;
        var rect = new Rect(0, 0, w, h);
        GUILayout.BeginArea(rect, (GUIStyle)"box");

        GUILayout.BeginHorizontal();
        GUILayout.Label("surface position texture");
        GUILayout.Label(texGen.surfacePosTex, GUILayout.Width(h / 2), GUILayout.Height(h / 2));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("surface normal texture");
        GUILayout.Label(texGen.surfaceNormTex, GUILayout.Width(h / 2), GUILayout.Height(h / 2));
        GUILayout.EndHorizontal();

        GUILayout.EndArea();
    }
}

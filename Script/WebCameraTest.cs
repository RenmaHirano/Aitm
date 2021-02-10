using UnityEngine;
using UnityEngine.UI;

public class WebCameraTest : MonoBehaviour {

    public RawImage rawImage;
    public GameObject Plane;
    WebCamTexture webCamTexture;

    void Start () {
        webCamTexture = new WebCamTexture();
        rawImage.texture = webCamTexture;
        webCamTexture.Play();
        Plane.GetComponent<MeshRenderer>().material.mainTexture = webCamTexture;
	}
	
	void Update (){
	}
}
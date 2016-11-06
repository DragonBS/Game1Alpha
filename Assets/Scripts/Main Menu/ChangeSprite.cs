using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeSprite : MonoBehaviour {

    private Sprite sourceSprite;
    public Image targetImage;

	public void Change_Sprite () {

        targetImage.sprite = GetComponent<Image>().sprite;

    }
}

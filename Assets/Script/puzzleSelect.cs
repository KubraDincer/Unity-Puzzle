using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puzzleSelect : MonoBehaviour
{
    /* Bu script dosyası, level kısmını oluşturuyor. CAmeranın içine atıyor.
     * Image(StartPanel) arkaplan larak ayarlıyor.
     * Üzerine button ekliyor.Textlerini siliyor.Image'leri puzzle resimlerini koyuyor.
     * Levelleri button olarak yapıyor.OnClick kısmına Camera->bu script ve fonksiyonu ayarlıyor.Resmi buton resmi yapıyor.
     
         */
    public GameObject StartPanel;
    public void SetPuzzlesPhoto(Image Photo)
    {
        for (int i = 0; i < 25; i++)
        {
            GameObject.Find("Piece (" + i + ")").transform.Find("Puzzle").GetComponent<SpriteRenderer>().sprite =Photo.sprite;
        }
        StartPanel.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class piceseScript : MonoBehaviour
{
     /* Bu Script dosyası DrapAndDrop ile bağlantılıdır. Puzzle'ın yanına parçaların konduğu bölümü yapıyoruz.
     * Hierarchy'e gameObject ekle.Sağ tarafa sürükle.Bu RightPosition olacak gibi...
     * Bu script'i Tüm parçalara ekle.
     * Arka plan için tahta deseni kullandı. Order or LAyer:-2 diye ayar yaptı.
     * UI->Image(Start Panel) ekle.Tüm ekranı kaplayacak boyutda (Canvas kadar) yap. Tahta resmini buna attı.
     * UI->Button.İçine kullandığı resmi attı. Bu menü olacak gibi. Butonu kopyalayıp resmini değiştiriyoruz.
     * Butonların OnClick kısmında MainCamera.setPuzzlesPhoto yapıyoruz.Imageyi kendi fotosunu koyuyoruz.
     * Sıralama şöyle::Canvas altında Image altında butonlar.
     */
    private Vector3 RightPosition;
    public bool InRightPosition;
    public bool Selected;
    void Start()
    {
        RightPosition = transform.position;
        transform.position = new Vector3(Random.Range(5f, 11f), Random.Range(2.5f, -7));
    }
    
    void Update()
    {
        if (Vector3.Distance(transform.position, RightPosition) < 0.5f)
        {
            if (!Selected)
            {
                if (InRightPosition == false)
                {
                    transform.position = RightPosition;
                    InRightPosition = true;
                    GetComponent<SortingGroup>().sortingOrder = 0;
                    Camera.main.GetComponent<DragAndDrop_>().PlacedPieces++;
                }
            }
        }
    }
}

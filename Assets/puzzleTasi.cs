using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzleTasi : MonoBehaviour
{
    //Bu script dosyası tek başınadır. Diğerleri ile bağlantılı değildir.


    /* Bu script dosyası:puzzle parçalarının taşımasını ve yerlerine oturmasını sağlıyor.
    Bu script parçaların içine atılıyor.Sağda parçalar(boxCollider2D ekliyor.), solda taban(kutular) olacak şekilde.
    kutulara tag (kutu) ekleniyor.
    Puzzle temelini yapıyor. ikinciye kopyala yapıştır yapıyor ve renklendiriyor.
    Buna kutular diyor. asıl olanı sağa alıyor.
    */
    Camera kamera;
    Vector2 baslangic_pozisyonu;
    GameObject[] kutu_dizisi;
    private void OnMouseDrag()
    {
        Vector3 pozisyon=kamera.ScreenToWorldPoint(Input.mousePosition);
        pozisyon.z=0;
        transform.position=pozisyon;
    }
    void Start()
    {
        kamera=GameObject.Find("Main Camera").GetComponent<Camera>();
        baslangic_pozisyonu=transform.position;

        kutu_dizisi=GameObject.FindGameObjectsWithTag("kutu");
    }
    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            foreach (GameObject kutu in kutu_dizisi)
            {
                if(kutu.name==gameObject.name)   
                {
                    float mesafe=Vector3.Distance(kutu.transform.position,transform.position);
                    if(mesafe<=1)
                    {
                        transform.position=kutu.transform.position;
                    }
                    else
                    {
                        transform.position=baslangic_pozisyonu;
                    }
                }
            }
        }
    }



}

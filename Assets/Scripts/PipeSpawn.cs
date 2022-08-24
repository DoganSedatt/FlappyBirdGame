using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public float maxTime = 1;
    public float timer = 0;
    public GameObject pipe;
    public float height;
    void Start()
    {
        GameObject newPipe = Instantiate(pipe);//Yeni pipe oluþtur
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        //Yeni oluþan pipe'ýn konumunu þöyle ayarla=mevcut piep konumu+Random Range'den gelen deðer.
        //Yükseklik konumunu rastgele ayaralmýþ oluyor;
    }

   
    void Update()
    {
        if (timer > maxTime)
        {//Eðer timer deðeri maxTime'den büyükse;
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            //Yeni pipe oluþtur ve bunu her 1 saniyede bir yap.
            Destroy(newPipe, 15);//Daha sonra o pipe'ý 15 saniyede yok et.
            timer = 0;//Timeri 0'a eþitleki bu kod sürekli döngü halinde çalýþsýn.
        }
        timer += Time.deltaTime;//Sayaç(Saniyede 1 artar);
    }
}

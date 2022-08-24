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
        GameObject newPipe = Instantiate(pipe);//Yeni pipe olu�tur
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        //Yeni olu�an pipe'�n konumunu ��yle ayarla=mevcut piep konumu+Random Range'den gelen de�er.
        //Y�kseklik konumunu rastgele ayaralm�� oluyor;
    }

   
    void Update()
    {
        if (timer > maxTime)
        {//E�er timer de�eri maxTime'den b�y�kse;
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            //Yeni pipe olu�tur ve bunu her 1 saniyede bir yap.
            Destroy(newPipe, 15);//Daha sonra o pipe'� 15 saniyede yok et.
            timer = 0;//Timeri 0'a e�itleki bu kod s�rekli d�ng� halinde �al��s�n.
        }
        timer += Time.deltaTime;//Saya�(Saniyede 1 artar);
    }
}

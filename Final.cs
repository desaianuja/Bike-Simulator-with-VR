using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO.Ports;
using System;
using System.Net;
//using Newtonsoft.Json;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.IO;
//using Firebase;
//using Firebase.Unity.Editor;
//using Firebase.Database;

public class Final : MonoBehaviour
{

    // private float AmountToMove;
    SerialPort serial;
    // Use this for initialization

    private int count;
    private Rigidbody rb;
    public Text countText;
    public Text winText;
    
    public Text welcomeText;
    public Text endText;
    public float turnSpeed = 50f;





    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
       // welcome WaitForSeconds(5);




        serial = new SerialPort("COM6", 9600);
        
        
         //     welcomeText.text = "";
       //       endText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (!serial.IsOpen)
            serial.Open();
        String data = serial.ReadLine().ToString().Trim();
        //   AmountToMove = 10;
        //   MoveObject(data);


        char x = data[data.Length - 1];

        if (data.Equals("100"))
        {
            welcomeText.text = "Welcome to Driving License Test";

        }//




        if (data.Equals("5"))
               {
                    transform.Rotate(Vector3.up, -5 , Space.World);
               }
               if (data.Equals("4"))
               {
                   transform.Rotate(Vector3.up, -4, Space.World);
               }

                if (data.Equals("3"))
               {
                   transform.Rotate(Vector3.up, -3, Space.World);
               }
               if (data.Equals("2"))
               {
                   transform.Rotate(Vector3.up, -2, Space.World);
               }
               if (data.Equals("1"))
               {
                   transform.Rotate(Vector3.up, -1, Space.World);
               }
               if (data.Equals("-1"))
               {
                   transform.Rotate(Vector3.up, 1, Space.World);
               }
               if (data.Equals("-2"))
               {
                   transform.Rotate(Vector3.up, 2, Space.World);
               }
               if (data.Equals("-3"))
               {
                   transform.Rotate(Vector3.up, 3, Space.World);
               }
               if (data.Equals("-4"))
               {
                   transform.Rotate(Vector3.up, 4, Space.World);
               }
               if (data.Equals("-5"))
               {
                   transform.Rotate(Vector3.up, 5, Space.World);
               }

       
        if (data.Equals("11"))
        {
            transform.Translate(Vector3.forward * 1 * Time.deltaTime);
        }
        if (data.Equals("12"))
        {
            transform.Translate(Vector3.forward * 2 * Time.deltaTime);
        }

        if (data.Equals("13"))
        {
            transform.Translate(Vector3.forward * 3 * Time.deltaTime);
        }
        if (data.Equals("14"))
        {
            transform.Translate(Vector3.forward * 4 * Time.deltaTime);
        }
        if (data.Equals("15"))
        {
            transform.Translate(Vector3.forward * 5 * Time.deltaTime);
        }
        if (data.Equals("16"))
        {
            transform.Translate(Vector3.forward * 6 * Time.deltaTime);
        }
        if (data.Equals("17"))
        {
            transform.Translate(Vector3.forward * 7 * Time.deltaTime);
        }
        if (data.Equals("18"))
        {
            transform.Translate(Vector3.forward * 8 * Time.deltaTime);
        }
        if (data.Equals("19"))
        {
            transform.Translate(Vector3.forward * 9 * Time.deltaTime);
        }
        if (data.Equals("20"))
        {
            transform.Translate(Vector3.forward * 10 * Time.deltaTime);
        }

        if (data.Equals("21"))
        {
            transform.Translate(Vector3.forward * -10, Space.World);
        }
        if (data.Equals("22"))
        {
            transform.Translate(Vector3.forward * -20, Space.World);
        }

        if (data.Equals("23"))
        {
            transform.Translate(Vector3.forward * -3, Space.World);
        }
        if (data.Equals("24"))
        {
            transform.Translate(Vector3.forward * -4, Space.World);
        }
        if (data.Equals("25"))
        {
            transform.Translate(Vector3.forward * -5, Space.World);
        }
        if (data.Equals("26"))
        {
            transform.Translate(Vector3.forward * -6, Space.World);
        }
        if (data.Equals("27"))
        {
            transform.Translate(Vector3.forward * -7, Space.World);
        }
        if (data.Equals("28"))
        {
            transform.Translate(Vector3.forward * -8, Space.World);
        }
        if (data.Equals("29"))
        {
            transform.Translate(Vector3.forward * -9, Space.World);
        }
        if (data.Equals("30"))
        {
            transform.Translate(Vector3.forward * -10, Space.World);
        }
       //      }
      //       else if (data.Equals("99"))
      //     {
      //              endText.text = "Sorry...You are Not Registerd User Please Register yourself";
      //       }

        
      /*
                while (count >= 1)
                {
                    //DateTime date = DateTime.Now;
                   // string Date = date.ToString("yyyy:MM:dd");
                   // string Time = date.ToString("HH:mm:ss");
                    var json = Newtonsoft.Json.JsonConvert.SerializeObject(new
                    {
                       
                        
                        score = count,

                    });
                    var request = WebRequest.Create("https://csharp-d61d2.firebaseio.com/.json");
                    request.Method = "POST";
                    request.ContentType = "application/json";
                    var buffer = Encoding.UTF8.GetBytes(json);
                    request.ContentLength = buffer.Length;
                    request.GetRequestStream().Write(buffer, 0, buffer.Length);
                    var response = request.GetResponse();
                    json = (new StreamReader(response.GetResponseStream())).ReadToEnd();

                }

                */
             

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
        
    }

    void SetCountText()
    {
        countText.text = "Rules Followed :" + count.ToString();
        if (count >= 0)
        {
            winText.text = "Congrats... You have Pass the Driving Test";

        }
    }

}

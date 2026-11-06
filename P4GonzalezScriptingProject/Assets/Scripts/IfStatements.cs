using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    //Creating the variables for my script
    int cupsInTheSink = 4;
    //Creating the variables for my script

    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        //my while loop is going to check if there are cups in the sink and if there are, it will wash them
        while (cupsInTheSink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupsInTheSink--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;          
    }


void TemperatureTest()
    { 
// If the coffee's temperature is greater than the hottest drinking temperature...\
if (coffeeTemperature > hotLimitTemperature)
{
    //... do this.
    print("Coffee is too hot.");
}
// If it isn't, but the coffee temperature is less than the coldest drinking temperature
else if (coffeeTemperature < coldLimitTemperature)
{
    // ... do this.
    print("Coffee is too cold");
}
// If it is neither of those then...
else
{
    // ... do this.
    print("Coffee is just right.");
   }
 }
}

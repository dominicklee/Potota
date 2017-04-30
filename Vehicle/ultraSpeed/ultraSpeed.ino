 /*************************************************************************************
 * Author: Elimeléc
 * 
 * Date: 06/14/2013 
 * 
 * Modified: Luigi Moca
 * 
 * Description: Arduino code is credited to 
 * Elimeléc, and was modified by Luigi Moca 
 * to convert RPM to mph.
 * 
 *************************************************************************************/

volatile int rpmcount = 0;
long int rpm = 0, mph = 0;
unsigned long lastmillis = 0;
const double diameter = 0.5729167;

void setup()
{
 Serial.begin(9600); 
 attachInterrupt(0, rpm_fan, FALLING);//interrupt cero (0) is on pin two(2).
}

void loop()
{ 
 if (millis() - lastmillis == 100)
 {  /*Uptade every one second, this will be equal to reading frecuency (Hz).*/
     detachInterrupt(0);    //Disable interrupt when calculating
     rpm = rpmcount * 150;  // Convert frequency to RPM
 
     mph = ((rpm * 60 * PI * diameter)/5280);

     Serial.println(mph,DEC);
     //Serial.println(" mph");
     rpmcount = 0; // Restart the RPM counter
     lastmillis = millis(); // Uptade lasmillis
     attachInterrupt(0, rpm_fan, FALLING); //enable interrupt
  }
}

 /* this code will be executed every time the interrupt 0 (pin2) gets low.*/
void rpm_fan()
{
  rpmcount++;
}

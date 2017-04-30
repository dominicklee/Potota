/*
  Wireless Serial Remote - Potota
  By Dominick Lee
 */
#include <SoftwareSerial.h>

SoftwareSerial mySerial(3,2); // RX, TX

void setup()  
{
  // Open serial communications and wait for port to open:
  Serial.begin(9600);

  // set the data rate for the SoftwareSerial port
  mySerial.begin(9600);
}

void loop() // run over and over
{
    mySerial.print('t');
    mySerial.println(analogRead(A0));
    delay(100);
    mySerial.print('s');
    mySerial.println(analogRead(A1));
    delay(100);
}  //end loop


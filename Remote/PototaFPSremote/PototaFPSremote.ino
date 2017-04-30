#include "FPS_GT511C3.h"
#include "SoftwareSerial.h"

FPS_GT511C3 fps(8,7);
SoftwareSerial nodemcu(11,12);
SoftwareSerial hc12(3,2);

boolean validated = false;

void setup()
{
	Serial.begin(9600);
        nodemcu.begin(9600);
        nodemcu.setTimeout(600);
        hc12.begin(9600);
	delay(100);
	fps.Open();
	fps.SetLED(true);
        pinMode(4, OUTPUT);  //buzzer
        digitalWrite(4, HIGH);
        delay(1000);
        digitalWrite(4, LOW);
}

void loop()
{
if (validated == false)
{
	if (fps.IsPressFinger())
	{
		fps.CaptureFinger(false);
		int id = fps.Identify1_N();
		if (id <200)
		{
			Serial.print("Verified ID:");
			Serial.println(id);
                        fps.SetLED(false);
                        nodemcu.print("valid");
                        validated = true;
		}
	}
	delay(50);
}
else
{
  //authenticated
  nodemcu.listen();
  while (nodemcu.available() > 0)
  {
   String inc = nodemcu.readString();
   hc12.println(inc);
  }
  
  hc12.print('t');
  hc12.println(analogRead(A0));
  delay(10);
  hc12.print('s');
  hc12.println(analogRead(A1));
  delay(10);

}

}  //void loop

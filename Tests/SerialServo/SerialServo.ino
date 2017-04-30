#include <Servo.h>

void servo(uint8_t);

Servo myservo;  // create servo object to control a servo

int incoming = 0;

void setup()
{
  Serial.begin(9600);
  myservo.attach(6);  // attaches the servo on pin # to the servo object
}

void loop()
{
  if (Serial.available() > 0)
  {
    incoming = Serial.parseInt();
    Serial.println(incoming);
    myservo.write(incoming);              // tell servo to go to position in variable 'pos'
  }
}

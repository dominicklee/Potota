
#include <Arduino.h>
#include <SoftwareSerial.h>
#include <Nextion.h>

SoftwareSerial nextion(D1,D2);// Nextion TX to pin 2 and RX to pin 3 of Arduino

Nextion myNextion(nextion, 9600); //create a Nextion object named myNextion using the nextion serial port @ 9600bps


void setup() {
  Serial.begin(9600);
  myNextion.init();
  pinMode(14, INPUT_PULLUP);
  pinMode(12, INPUT_PULLUP);
}

void loop() {
  String message = myNextion.listen(); //check for message
  if(message != ""){ // if a message is received...
    Serial.println(message); //...print it out
  }

  if (digitalRead(14) == false)
  {
    Serial.println("mode");
    while(digitalRead(14) == false)
    {
      delay(100);
    }
  }
  
  if (digitalRead(12) == false)
  {
    Serial.println("brake");
    while(digitalRead(12) == false)
    {
      delay(100);
    }
  }

  if (Serial.available() > 0)
  {
    String incoming = Serial.readString();
    if (incoming == "valid")
    {
      myNextion.sendCommand("page 1");
    }
  }

  
}


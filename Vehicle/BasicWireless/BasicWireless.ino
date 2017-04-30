/*
  Wireless Serial Vehicle ECU - Potota
  By Dominick Lee
 */
#include <Servo.h> 

Servo servo1;
Servo servo2;
Servo servo3;
Servo servo4;
Servo servo5;

int incomingByte = 0;   //For incoming serial data

int steeringCH = 7;  //PWM for steering
int throttleCH = 6;  //PWM for throttle
int shiftCH = 5;  //PWM for shifting gears
int tlockFront = 4;  //PWM for front tlock
int tlockRear = 3;  //PWM for rear tlock

int rear = 12;   //obstacle
int front = 11;  //obstacle
int wentBack = 0;

int pos1 = 90;
int pos2 = 90;

int mode = 0;  //0=drive, 1=reverse, 2=lanefollow, 3=cruisecontrol, 4=selfpark

//Calculate motors
float y;
float easing = 0.02;

void setup()  
{
  // Open serial communications and wait for port to open:
  Serial.begin(9600);
  
  pinMode(rear, OUTPUT);
  pinMode(front, INPUT);
  
  servo1.attach(steeringCH); 
  servo2.attach(throttleCH); 
  servo3.attach(shiftCH); 
  servo4.attach(tlockFront); 
  servo5.attach(tlockRear); 
}

void loop() // run over and over
{
      // send data only when you receive data:
        if (Serial.available() > 0)
        {
                // read the incoming byte:
                incomingByte = Serial.read();
                
                
                if (incomingByte == 115)
                {  //we got steering (S)
                  int x1 = Serial.parseInt();
                  pos1 = map(x1,0,1022,0,180);
                  //Serial.print("s ");
                  //Serial.println(pos1);
                  servo1.write(pos1);             
                }
                
                if (incomingByte == 116)
                {  //we got throttle (t)
                  int x2 = Serial.parseInt();
                  pos2 = map(x2,0,1022,25,160);
                  

                  //Serial.print("t ");
                  //Serial.println(pos2);
                  float dy = pos2 - y;
                  y += dy * easing;
                  
                  if (mode == 0)  //going forward
                  {
                    easing = 0.03; 
                    int pos = constrain(y,90,160);
                    if (digitalRead(front) == HIGH && mode == 0)  //obstacle behind
                    {
                       servo2.write(90);
                    }
                    else
                    {
                      servo2.write(pos);
                    }
                  }
                  else if (mode == 1)  //going backward
                  {
                    //easing = 0.03; 
                    int pos = constrain(y,25,90);
                    if (pos < 85)
                    {
                      if (wentBack < 3)
                      {
                        servo2.write(90); 
                        delay(100);
                        servo2.write(89); 
                        delay(100);
                        servo2.write(88); 
                        delay(100);
                        servo2.write(87); 
                        delay(100);
                        servo2.write(86); 
                        delay(100);
                        servo2.write(85); 
                        delay(100);
                        servo2.write(80); 
                        delay(100);
                        wentBack++;    
                      }    
                      else
                      {
                        servo2.write(pos); 
                        
                      }              
                    }
                  }
                  
                }
                
                if (incomingByte == 100)
                {  //set drive mode
                   mode = 0;
                }
                
                if (incomingByte == 114)
                {  //set reverse mode
                   mode = 1;
                }
                
                if (incomingByte == 99)
                {  //set cruise control mode
                   mode = 3;
                }
                
                if (incomingByte == 0x7a)
                {  //set high gear
                   servo3.write(124);
                }
                
                if (incomingByte == 0x78)
                {  //set low gear
                   servo3.write(60);
                }
                
                if (incomingByte == 0x71)
                {  //no diff
                   servo4.write(40);
                   delay(100);
                   servo5.write(40);
                   delay(100);
                }
                
                if (incomingByte == 0x77)
                {  //front diff
                   servo4.write(110);
                   delay(100);
                   servo5.write(40);
                   delay(100);
                }
                
                if (incomingByte == 0x65)
                {  //both diffs
                   servo4.write(110);
                   delay(100);
                   servo5.write(130);
                   delay(100);
                }
        }  //end serial

}  //end loop

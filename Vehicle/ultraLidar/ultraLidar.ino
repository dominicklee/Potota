#include <Servo.h>

Servo myservo;  // create servo object to control a servo

int lidar(void);
void initPorts(void);
void servo(uint8_t);

int pos = 0;    // variable to store the servo position

void setup()
{
  Serial.begin(9600);
  initPorts();  //initializes ports
  pinMode(11, OUTPUT);
}

void loop()
{
  servo(4);

}

int lidar()
{
  uint16_t pulseWidth = 0;
  pulseWidth = pulseIn(3, HIGH); // Count how long the pulse is high in microseconds

  // If we get a reading that isn't zero, let's print it
  if(pulseWidth != 0)
  {
    pulseWidth = pulseWidth / 10.00; // 10usec = 1 cm of distance
    pulseWidth -=6.00;  //removes error
    pulseWidth = pulseWidth/2.54;  //converts cm to inches
    
    
    //Serial.print("Lidar: ");
    //Serial.print(pulseWidth); // Print the distance
    //Serial.println(" in.  ");
    return pulseWidth;
  }
  else
  {
    return -1; 
  }
}

void initPorts()
{

  pinMode(3, INPUT); // Set pin 3 as monitor pin
  pinMode(4, OUTPUT);  //pin for rotating the servo
}

void servo(uint8_t pin)
{
  pinMode(11, OUTPUT);
  myservo.attach(pin);  // attaches the servo on pin # to the servo object
  int closestDist = 30000;  //closest distance in inches
  
  for(pos = 65; pos < 155; pos += 5)  // goes from 0 degrees to 180 degrees 
  {                                  // in steps of 1 degree 
    int curDist = lidar();
    Serial.println(curDist);
    if (curDist < closestDist)
    {
      closestDist = curDist;
    }
    if (closestDist < 24)
    {
      digitalWrite(11, HIGH);
    }
    else
    {
      myservo.write(pos);              // tell servo to go to position in variable 'pos' 
      digitalWrite(11, LOW);
    }
    delay(3);
  } 
  for(pos = 155; pos>=65; pos-=5)     // goes from 180 degrees to 0 degrees 
  {                                
    int curDist = lidar();
    Serial.println(curDist);
    if (curDist < closestDist)
    {
      closestDist = curDist;
    }
    if (closestDist < 25)
    {
    }
    else
    {
      myservo.write(pos);              // tell servo to go to position in variable 'pos' 
    }
    delay(3);
  } 
}
